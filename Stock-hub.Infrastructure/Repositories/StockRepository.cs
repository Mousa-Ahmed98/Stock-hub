using Microsoft.EntityFrameworkCore;
using Stock_hub.Application;
using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly StockDbContext _stockDbContext;

        public StockRepository(StockDbContext stockDbContext)
        {
            this._stockDbContext = stockDbContext;
        }

        public async Task<Stock> AddStock(Stock stock)
        {
            _stockDbContext.Stocks.Add(stock);
            await _stockDbContext.SaveChangesAsync();
            return stock;
        }

        public async Task<IReadOnlyList<Stock>> GetAllStocks()
        {
            return await _stockDbContext.Stocks.ToListAsync();
        }
    }
}
