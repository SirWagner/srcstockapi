


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using BTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Stocks.API.Controllers
{
    [Route("api/Stocks/[controller]")]
    [ApiController]
   
    public class EntitiesController : ControllerBase
    {
        private readonly BTContext _db;


        public EntitiesController(BTContext db)
        {
            _db = db;
        }

        // GET: api/Unities
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var proj = await _db.Entity.ToListAsync();
                return Ok(proj);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving units: " + ex.Message);
            }
        }
    }
}