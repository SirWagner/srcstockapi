using System.Threading.Tasks;
using Stocks.API.Extensions;
using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.BSEntities.Inventory;
using Stocks.Domain.Helpers;
using Stocks.Domain.Helpers.Product;
using Stocks.Domain.Helpers.Stocks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Stocks.API.Controllers
{
    [Route("api/Stocks/[controller]")]
    [ApiController]
 
    public class ArtigoController : ControllerBase
    {
        private readonly StudentContext _db;


        public ArtigoController(StudentContext db)
        {
            _db = db;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var units = await _db.Products.ToListAsync();
                return Ok(units);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving units: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var unit = await _db.Products.FindAsync(id);
                if (unit == null)
                    return NotFound("Unit not found.");

                return Ok(unit);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving unit by ID: " + ex.Message);
            }
        }

        [HttpGet("byWarehouse")]
        public async Task<IActionResult> GetByWarehouse([FromQuery] string codBarras)
        {
            try
            {
                var units = await _db.Products.Where(p => p.CodBarras == codBarras).ToListAsync();
                return Ok(units);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving units by warehouse: " + ex.Message);
            }
        }
        [HttpPost]
        public JsonResult Upsert(Artigo product)
        {
            if (product.IdEstado == null)
            {
                _db.Products.Add(product);
            }
            else
            {
                var productid = _db.Products.Find(product.IdEstado);
                if (productid == null)
                    return new JsonResult(NotFound());

                productid = product;
            }

            _db.SaveChanges();
            return new JsonResult(Ok(product));


        }
    }
}

//        // GET: api/Products
//        [HttpGet]
//        [Route("filters")]
//        public async Task<IActionResult> Get([FromQuery] ProductParams productParams)
//        {
//            var products = await _productServices.GetAllAsync(productParams);

//            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalRecords, products.TotalPages);
//            return Ok(products);
//        }

//        // GET: api/Products
//        [HttpGet]
//        [Route("GasBottle")]
//        public async Task<IActionResult> GetGasBottle([FromQuery] ProductParams productParams)
//        {
//            if (string.IsNullOrWhiteSpace(productParams.Project))
//                productParams.Project = "all";

//            var products = await _productServices.GetCanisterInProject(productParams);

//            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalRecords, products.TotalPages);
//            return Ok(products);
//        }

//        // GET: api/Products/5
//        [HttpGet("{identifier}")]
//        public async Task<IActionResult> Get(string identifier)
//        {
//            return Ok( await _productServices.GetByIdAsync(identifier));
//        }

//        // GET: api/Products/entity/F0010
//        [HttpGet]
//        [Route("entity/{entityId}")]
//        public async Task<IActionResult> GetWithEntity(string entityId, [FromQuery] ProductParams productParams)
//        {
//            var products = await _productServices.GetWithEntityAsync(entityId, productParams);
//            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalRecords, products.TotalPages);
//            return Ok(products);
//        }

//        [HttpGet]
//        [Route("entity/{entityId}/filters")]
//        public async Task<IActionResult> GetWithEntityInStock(string entityId, [FromQuery] ProductParams productParams)
//        {
//            var products = await _productServices.GetWithEntityAsync(entityId, productParams);
//            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalRecords, products.TotalPages);
//            return Ok(products);
//        }


//        [HttpGet]
//        [Route("supplier/{supplierId}")]
//        public async Task<IActionResult> GetProductOfSupplier(string supplierId, [FromQuery] ProductParams productParams)
//        {
//            var products = await _productServices.GetProductOfSupplier(supplierId, productParams);
//            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalRecords, products.TotalPages);
//            return Ok(products);
//        }

//        [HttpGet]
//        [Route("warehouse/{warehouseId}/filters")]
//        public async Task<IActionResult> GetWithWarehouseInStock(string warehouseId, [FromQuery] ProductParams productParams)
//        {
//            var products = await _productServices.GetWithWarehouseAsync(warehouseId, productParams);
//            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalRecords, products.TotalPages);
//            return Ok(products);
//        }


//        [HttpGet]
//        [Route("types")]
//        public async Task<IActionResult> GetProductTypes([FromQuery] DefaultPaginationParams paginationParams)
//        {
//            var productTypes = await _productServices.GetTypes(paginationParams);

//            Response.AddPagination(productTypes.CurrentPage, productTypes.PageSize, productTypes.TotalRecords, productTypes.TotalPages);
//            return Ok(productTypes);
//        }

//        [HttpGet]
//        [Route("suppliers")]
//        public async Task<IActionResult> GetSuppliers([FromQuery] ProductParams productParams)
//        {
//            var suppliers = await _productServices.GetSuppliers(productParams);

//            Response.AddPagination(suppliers.CurrentPage, suppliers.PageSize, suppliers.TotalRecords, suppliers.TotalPages);
//            return Ok(suppliers);
//        }

//        [HttpPost]
//        [Route("suppliers")]
//        public async Task<IActionResult> CreateSuppliers(Fornecedor supplier)
//        {
//            return Ok(await _productServices.CreateSupplier(supplier));
//        }

//        [HttpGet]
//        [Route("statuses")]
//        public async Task<IActionResult> GetStatuses([FromQuery] StatusParams statusParams)
//        {
//            var productStatuses = await _productServices.GetSatuses(statusParams);

//            Response.AddPagination(productStatuses.CurrentPage, productStatuses.PageSize, productStatuses.TotalRecords, productStatuses.TotalPages);
//            return Ok(productStatuses);
//        }

//        //Status filters
//        [HttpGet]
//        [Route("statuses/filters")]
//        public async Task<IActionResult> GetStatusesWithFilters([FromQuery] StatusParams statusParams)
//        {
//            var productStatuses = await _productServices.GetSatuses(statusParams);

//            Response.AddPagination(productStatuses.CurrentPage, productStatuses.PageSize, productStatuses.TotalRecords, productStatuses.TotalPages);
//            return Ok(productStatuses);
//        }

//        // POST: api/Products
//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] Artigo data)
//        {
//            return StatusCode(201, await _productServices.SaveAsync(data));
//        }
//    }
//}
