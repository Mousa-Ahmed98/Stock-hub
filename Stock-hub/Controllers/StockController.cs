using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Stock_hub.Application.DTOS;
using Stock_hub.Application.Hubs;
using Stock_hub.Application.Interfaces;

namespace Stock_hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;
        private readonly IMapper _mapper;

        public StockController(IStockService stockService, IMapper mapper)
        {
            _stockService = stockService;
            _mapper = mapper;
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
             return Ok(await _stockService.GetAllStocks());
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(StockUpdateReqDto stockUpdateDto)
        {
            if (ModelState.IsValid)
            {   
                bool IsUpdated = await _stockService.UpdateStock(stockUpdateDto);

                if(IsUpdated)
                {
                    return Ok();
                }
                return BadRequest();
            }

            return BadRequest(ModelState);
        }


        [HttpGet("{symbol}/history")]
        public async Task<IActionResult> Get(string symbol)
        {
            return Ok(await _stockService.GetStockHistory(symbol));
        }


        [HttpGet("GetOnlySymbols")]
        public async Task<IActionResult> GetOnlySymbols()
        {
            return Ok(await _stockService.GetOnlySymbols());
        }
    }
}
