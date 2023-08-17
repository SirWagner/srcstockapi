using System.Threading.Tasks;
using Stocks.API.Extensions;
using Stocks.Domain.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Stocks.API.Controllers
{
    [Route("api/Stocks/[controller]")]
    [ApiController]
    
    public class EmployeesController : ControllerBase
    {
        private readonly BTContext _db;


        public EmployeesController(BTContext db)
        {
            _db = db;
        }

        // GET: api/Unities
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var proj = await _db.Funcionario.ToListAsync();
                return Ok(proj);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving units: " + ex.Message);
            }
        }
    }
}
