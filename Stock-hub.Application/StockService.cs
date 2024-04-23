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
        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public async Task<Stock> AddStock(Stock stock)
        {
            return await _stockRepository.AddStock(stock);
            
        }

        public async Task<IReadOnlyList<Stock>> GetAllStocks()
        {
            return await _stockRepository.GetAllStocks();
        }
    }
}
