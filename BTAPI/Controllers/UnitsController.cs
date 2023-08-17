using System.Threading.Tasks;
using Stocks.API.Extensions;

using Stocks.Domain.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BTAPI.Models;
using BTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Stocks.API.Controllers
{
    [Route("api/Unit/[controller]")]
    [ApiController]
    
    public class UnitsController : ControllerBase
    {
        private readonly BTContext _db;

        public UnitsController(BTContext db)
        {
            _db = db;
        }
        // GET: api/Unities
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var units = await _db.Units.ToListAsync();
                return Ok(units);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving units: " + ex.Message);
            }
        }
    }
}
