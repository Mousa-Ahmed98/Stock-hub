using AutoMapper;
using Stock_hub.Application.DTOS;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application
{
    public class StockService : IStockService
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
        }

        public async Task<Stock> AddStock(Stock stock)
        {
            return await _stockRepository.AddStock(stock);
            
        }

        public async Task<IReadOnlyList<Stock>> GetAllStocks()
        {
            return await _stockRepository.GetAllStocks();
        }

        public async Task<IReadOnlyList<StockUpdate>> GetStockHistory(string symbol)
        {
            return await _stockRepository.GetStockHistory(symbol);
        }

        public async Task<bool> UpdateStock(StockUpdateDto stockUpdateDto)
        {
            StockUpdate stockUpdate = _mapper.Map<StockUpdate>(stockUpdateDto);
            stockUpdate.TimeStamp = DateTime.Now;

            return await _stockRepository.UpdateStock(stockUpdate);
        }
    }
}
