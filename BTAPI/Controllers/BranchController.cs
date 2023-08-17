using System.Threading.Tasks;
using Stocks.API.Extensions;
using Stocks.Domain.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BTAPI.Models;
using Microsoft.EntityFrameworkCore;
using Stocks.Domain.BSEntities.Base;

namespace Stocks.API.Controllers
{
    [Route("api/Stocks/[controller]")]
    [ApiController]
    //[Authorize]
    public class BranchController : ControllerBase
    {
        private readonly BTContext _db;


        public BranchController(BTContext db)
        {
            _db = db;
        }

        // GET: api/Unities
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var branch = await _db.Filial.ToListAsync();
                return Ok(branch);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving column: " + ex.Message);
            }
        }

        [HttpGet("{branch}")]
        public async Task<IActionResult> GetOne(string branch)
        {
            try
            {
                var foundBranch = await _db.Filial.FirstOrDefaultAsync(b => b.Codigo == branch);

                if (foundBranch == null)
                {
                    return NotFound($"Branch '{branch}' not found.");
                }

                return Ok(foundBranch);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving branch: " + ex.Message);
            }
        }

        [HttpPut("{Identifier}")]
        public async Task<IActionResult> Put(string branch, string Identifier, [FromBody] Filial updatedBranch)
        {
            try
            {
                var existingBranch = await _db.Filial.FirstOrDefaultAsync(b => b.Codigo == branch);

                if (existingBranch == null)
                {
                    return NotFound($"Branch '{branch}' not found.");
                }

                existingBranch.Codigo = Identifier;

                _db.Filial.Update(existingBranch);
                await _db.SaveChangesAsync();

                return Ok("Branch updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error updating branch: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Filial newBranch)
        {
            try
            {
                // Add the new branch to the DbSet
                _db.Filial.Add(newBranch);
                await _db.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { branch = newBranch.Codigo }, newBranch);
            }
            catch (Exception ex)
            {
                return BadRequest("Error creating branch: " + ex.Message);
            }
        }



    }
}
