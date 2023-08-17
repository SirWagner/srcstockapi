using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Stocks.API.Extensions;
using Stocks.Core.DTOs.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using BTAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace Stocks.API.Controllers
{

    [Route("api/Stocks/[controller]")]
    [ApiController]
    //[Authorize]
    public class AuthController : ControllerBase
    {
        private readonly BTContext _db;
        private readonly IConfiguration _config;


        public AuthController(BTContext db, IConfiguration config)
        {
            _db = db;
            _config = config ?? throw new ArgumentNullException(nameof(config));
        

        }

        [HttpPost]
        [Route("Create")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] BTAPI.Models.UserToCreate userToCreate)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (userToCreate.ConfirmPassword != userToCreate.Password)
                {
                    ModelState.AddModelError("ConfirmPassword", "Password and Confirm Password do not match.");
                    return BadRequest(ModelState);
                }

                if (await _db.UserToCreate.AnyAsync(u => u.Email == userToCreate.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    return BadRequest(ModelState);
                }

                var newUser = new BTAPI.Models.UserToCreate
                {
                    FirstName = userToCreate.FirstName,
                    LastName = userToCreate.LastName,
                    PhoneNumber1 = userToCreate.PhoneNumber1,
                    PhoneNumber2 = userToCreate.PhoneNumber2,
                    Email = userToCreate.Email,
                    Password = userToCreate.Password,
                 
                };

                _db.UserToCreate.Add(newUser);
                await _db.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
            }
            catch (Exception ex)
            {
                return BadRequest("Error registering user: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("GetUser/{email}")]
        public async Task<IActionResult> GetUser(string email)
        {
            try
            {
                var user = await _db.UserForLogin.FirstOrDefaultAsync(u => u.Email == email);
                if (user != null)
                {
                    return Ok(user);
                }
                return NotFound("User not found.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving user: " + ex.Message);
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(BTAPI.Models.UserForLogin userForLogin)
        {
            try
            {
                var userFromRepo = await _db.UserForLogin.FirstOrDefaultAsync(u => u.Email == userForLogin.Email);

                if (userFromRepo == null)
                {
                    return Unauthorized("Invalid email or password.");
                }

                var tokenValue = _config.GetSection("AppSettings:Token")?.Value;
                if (string.IsNullOrEmpty(tokenValue))
                {
                    return StatusCode(500, "Token configuration is missing or invalid.");
                }

                var claims = new[]
                {
                new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                new Claim(ClaimTypes.Email, userFromRepo.Email),
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenValue));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = creds,
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);

                return Ok(new
                {
                    token = tokenHandler.WriteToken(token),
                    userEmail = userForLogin.Email,
                    expiresIn = tokenDescriptor.Expires,
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    




        [HttpPut("{Email}")]
        public async Task<IActionResult> UpdateUser(string Email, [FromBody] BTAPI.Models.UserToCreate userToUpdate)
        {
            try
            {
                var existingUser = await _db.UserToCreate.FirstOrDefaultAsync(u => u.Email == userToUpdate.Email);

                if (existingUser == null)
                {
                    return NotFound();
                }

               
                existingUser.FirstName = userToUpdate.FirstName;
                existingUser.LastName = userToUpdate.LastName;
                existingUser.PhoneNumber1 = userToUpdate.PhoneNumber1;
                existingUser.PhoneNumber2 = userToUpdate.PhoneNumber2;

        

                _db.UserToCreate.Update(existingUser);
                await _db.SaveChangesAsync();

                return Ok(existingUser);
            }
            catch (Exception ex)
            {
                return BadRequest("Error updating user: " + ex.Message);
            }
        }



    }
}
