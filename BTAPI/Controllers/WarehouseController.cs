using Stocks.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BTAPI.Models;
using Stocks.API.Extensions;
using Stocks.Domain.Helpers;


namespace BTAPI.Controllers
{
    [Route("api/Warehouse/[controller]")]
    [ApiController]
  
    public class WarehouseController : ControllerBase
    {
        private readonly BTContext _db;      

        public WarehouseController(BTContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] DefaultPaginationParams paginationParams)
        {
            try
            {
                var warehouses = new List<Warehouse>
                {
                    new Warehouse { Default = "Warehouse1", TotalStock = 100 },
                    new Warehouse { Default = "Warehouse2", TotalStock = 200 }
                };

                Response.AddPagination(1, 10, warehouses.Count, 1);

                return Ok(warehouses);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving warehouses: " + ex.Message);
            }
        }

        [HttpGet("{warehouseId}")]
        public async Task<IActionResult> Get(string warehouseId)
        {
            try
            {
                var warehouse = new Warehouse
                {
                    Default = "Warehouse1",
                    TotalStock = 100,
                    Items = new WarehouseItem
                    {
                        Wharehouse = "Warehouse1",
                        Stock = 50
                    }
                };

                return Ok(warehouse);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving warehouse: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Warehouse warehouse)
        {
            try
            {
              
                _db.Warehouse.Add(warehouse);
                await _db.SaveChangesAsync();

                return Ok(warehouse);
            }
            catch (Exception ex)
            {
                return BadRequest("Error creating warehouse: " + ex.Message);
            }
        }

        [HttpPut("{warehouseId}")]
        public async Task<IActionResult> Put(string warehouseId, [FromBody] Warehouse warehouse)
        {
            try
            {
            
                var existingWarehouse = await _db.Warehouse.FindAsync(warehouseId);

                if (existingWarehouse != null)
                {
                    existingWarehouse.Default = "UpdatedWarehouse";
                    await _db.SaveChangesAsync();
                    return Ok(existingWarehouse);
                }
                else
                {
                    return NotFound("Warehouse not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error updating warehouse: " + ex.Message);
            }
        }
    }
}
