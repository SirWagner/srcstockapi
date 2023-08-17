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
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class DocumentController : ControllerBase
    {
        private readonly BTContext _db;


        public DocumentController(BTContext db)
        {
            _db = db;
        }

        // GET: api/Unities
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                var document = _db.DocumentToCreate.ToList();
                return new JsonResult (Ok(document));
            }
            catch (Exception ex)
            {
                return new JsonResult (BadRequest("Error retrieving units: " + ex.Message));
            }
        }

        [HttpGet("{branch}")]
        public async Task<IActionResult> GetOne(int numDoc)
        {
            try
            {
                var foundNumDoc = await _db.DocumentToCreate.FirstOrDefaultAsync(b => b.NumDoc == numDoc);

                if (foundNumDoc == null)
                {
                    return NotFound($"Branch '{numDoc}' not found.");
                }

                return Ok(foundNumDoc);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving branch: " + ex.Message);
            }
        }

        [HttpPut("{numDoc}")]
        public async Task<IActionResult> Put(int id, int numDoc, [FromBody] Filial updatedBranch)
        {
            try
            {
                var existingDoc = await _db.DocumentToCreate.FirstOrDefaultAsync(b => b.Id == id);

                if (existingDoc == null)
                {
                    return NotFound($"Branch '{id}' not found.");
                }

                existingDoc.NumDoc = numDoc;

                _db.DocumentToCreate.Update(existingDoc);
                await _db.SaveChangesAsync();

                return Ok("Branch updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error updating branch: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DocumentToCreate newDocument)
        {
            try
            {
                // Add the new branch to the DbSet
                _db.DocumentToCreate.Add(newDocument);
                await _db.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { document = newDocument.ArmazemOrigem }, newDocument);
            }
            catch (Exception ex)
            {
                return BadRequest("Error creating branch: " + ex.Message);
            }
        }



    }
}
