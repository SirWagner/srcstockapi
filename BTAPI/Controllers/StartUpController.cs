using Microsoft.AspNetCore.Mvc;

namespace Stocks.API.Controllers
{
    [Route("api/Status/[controller]")]
    [ApiController]
    public class StartUpController : ControllerBase
    {
        // main entry of API
        [HttpGet]
        public string Get() =>  "The API v2 is running || Developed by sirwagner4.4@gmail.com"; 
    }
}
