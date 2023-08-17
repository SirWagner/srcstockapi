using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Stocks.API.Extensions;
using Stocks.Domain.BSEntities.Inventory;
using Stocks.Domain.Helpers;
using Stocks.Domain.Helpers.Stocks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Stocks.API.Controllers
{
    [Route("api/Stocks/[controller]")]
    [ApiController]
 
    public class StocksController : ControllerBase
    {
        private readonly BTContext _db;
        

        public StocksController(BTContext db)
        {
            _db = db;
        }

        // GET: api/Unities
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var units = await _db.CabecInterno.ToListAsync();
                return Ok(units);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving units: " + ex.Message);
            }
        }


        // GET: api/Stocks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var unit = await _db.CabecInterno.FindAsync(id);
                if (unit == null)
                {
                    return NotFound("Unit not found.");
                }

                return Ok(unit);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving unit: " + ex.Message);
            }
        }



        // PUT: api/Stocks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CabecInterno unitData)
        {
            try
            {
                var existingUnit = await _db.CabecInterno.FindAsync(id);
                if (existingUnit == null)
                {
                    return NotFound("Unit not found.");
                }

                // Update the properties of the existing unit with the values from unitData
                existingUnit.ArmazemOrigem = unitData.ArmazemOrigem;
                existingUnit.IdDocumentoOrigem = unitData.IdDocumentoOrigem;
                existingUnit.LocalizacaoOrigem = unitData.LocalizacaoOrigem;

                _db.CabecInterno.Update(existingUnit);
                await _db.SaveChangesAsync();

                return Ok("Unit updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error updating unit: " + ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CabecInterno unitData)
        {
            try
            {
                // Add the new unit to the database
                _db.CabecInterno.Add(unitData);
                await _db.SaveChangesAsync();

                // Return the newly created unit with the generated ID
                return Ok(unitData);
            }
            catch (Exception ex)
            {
                return BadRequest("Error creating unit: " + ex.Message);
            }
        }



        //[HttpGet]
        //[Route("filters")]
        //public async Task<IActionResult> GetStocks([FromQuery] DateTime dateBegin,
        //    [FromQuery] DateTime dateEnd, [FromQuery] EntityBalanceParams paginationParams)
        //{
        //    if (string.IsNullOrWhiteSpace(paginationParams.Warehouse) || paginationParams.Warehouse == "undefined")
        //        return BadRequest("The warehouse is required. Please provide this parameter.");

        //    var items = await _stocksServices.GetAllLinesStocks(dateBegin, dateEnd, paginationParams);
        //    Response.AddPagination(items.CurrentPage, items.PageSize, items.TotalRecords, items.TotalPages);
        //    return Ok(items);
        //}

        //[HttpGet]
        //[Route("pending")]
        //public async Task<IActionResult> GetPendingDelivery([FromQuery]  PendingLineParams pendingLineParams)
        //{
        //    var items = await _stocksServices.GetPendingLines(pendingLineParams);
        //    Response.AddPagination(items.CurrentPage, items.PageSize, items.TotalRecords, items.TotalPages);
        //    return Ok(items);
        //}

        //[HttpGet]
        //[Route("balance")]
        //public async Task<IActionResult> GetEntityBalances([FromQuery]  EntityBalanceParams entityBalanceParams)
        //    => Ok(await _stocksServices.GetEntityBalance(entityBalanceParams, _configuration.GetConnectionString("DefaultConnection")));

        ////TODO: Make it better (call from its controller)
        //[HttpGet]
        //[Route("erpbalance")]
        //public async Task<IActionResult> GetERPBalances([FromQuery] DefaultPaginationParams defaultPaginationParams)
        //{
        //    var connectionStringERP = _configuration.GetConnectionString("PrimaveraERPCnn");
                
        //    var balances = await _stocksServices.GetStockFromERP(defaultPaginationParams, connectionStringERP);
        //    return Ok(balances);
        //}

        //// POST: api/Stocks
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] CabecInterno data)
        //{
        //    //Get and Set user that is about to perform the action 
        //    data.Utilizador = User.FindFirst(ClaimTypes.Email)?.Value;            

        //    var validationResult = data.ValidateModel();

        //    if (!string.IsNullOrWhiteSpace(validationResult)) return BadRequest(validationResult);

        //    //Todo: Update docfile
        //    var resp = await _stocksServices.SaveAsync(data);

        //    return Created(resp.Id.ToString(), new { id = resp.Id, parent_id = resp.IdDocumentoOrigem });
        //}
    }
}
