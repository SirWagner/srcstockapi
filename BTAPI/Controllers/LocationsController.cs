using Stocks.API.Extensions;
using Stocks.Domain.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BTAPI.Models;
using Stocks.Domain.BSEntities.Inventory;

namespace Stocks.API.Controllers
{
    [Route("api/Location/[controller]")]
    [ApiController]
   
    public class LocationsController : ControllerBase
    {
        private readonly BTContext _db;


        public LocationsController(BTContext db)
        {
            _db = db;
        }

            [HttpGet]
            public IActionResult GetAll()
            {
                try
                {
                    var locations = _db.ArmazemLocalizacoes.ToList();
                    return Ok(locations);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error retrieving locations: " + ex.Message);
                }
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                try
                {
                    var location = _db.ArmazemLocalizacoes.Find(id);
                    if (location == null)
                    {
                        return NotFound();
                    }

                    return Ok(location);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error retrieving location: " + ex.Message);
                }
            }

            [HttpGet("bycode/{code}")]
            public IActionResult GetByCode(string code)
            {
                try
                {
                    var location = _db.ArmazemLocalizacoes.FirstOrDefault(l => l.localizacao == code);
                    if (location == null)
                    {
                        return NotFound();
                    }

                    return Ok(location);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error retrieving location: " + ex.Message);
                }
            }

            [HttpPost]
            public IActionResult Post(ArmazemLocalizacoes location)
            {
                try
                {
                    _db.ArmazemLocalizacoes.Add(location);
                    _db.SaveChanges();

                    return Ok(location);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error creating location: " + ex.Message);
                }
            }

            [HttpPut("{id}")]
            public IActionResult Put(int id, ArmazemLocalizacoes updatedLocation)
            {
                try
                {
                    var existingLocation = _db.ArmazemLocalizacoes.Find(id);
                    if (existingLocation == null)
                    {
                        return NotFound();
                    }

                    existingLocation.localizacao = updatedLocation.localizacao;
                    // Update other properties as needed

                    _db.ArmazemLocalizacoes.Update(existingLocation);
                    _db.SaveChanges();

                    return Ok(existingLocation);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error updating location: " + ex.Message);
                }
            }

    }
}



