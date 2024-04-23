using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock_hub.Application.DTOS;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;

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
        public async Task<IActionResult> Update(StockUpdateDto stockUpdateDto)
        {
            if (ModelState.IsValid)
            {   
                bool IsUpdated = await _stockService.UpdateStock(stockUpdateDto);

                if(IsUpdated)
                {
                    return Ok("stock updated successfully");
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
    }
}
