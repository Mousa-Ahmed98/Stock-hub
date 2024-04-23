using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock_hub.Application;
using Stock_hub.Core.Entities;

namespace Stock_hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
             return Ok(await _stockService.GetAllStocks());
            
        }
    }
}
