using Microsoft.EntityFrameworkCore;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;
using System;
using System.Collections;
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

        public async Task<Stock> GetStockAsync(string symbol)
        {
            Stock stock = await _stockDbContext.Stocks.FindAsync(symbol);
            return stock;
        }

        public async Task<IReadOnlyList<StockUpdate>> GetStockHistory(string symbol)
        {
            return await _stockDbContext.StocksHistory
                .Where(s => s.Symbol == symbol)
                .ToListAsync();
        }

        public async Task<bool> UpdateStock(StockUpdate stockUpdate)
        {
            Stock stock = await GetStockAsync(stockUpdate.Symbol);

            stock!.CurrentPrice = stockUpdate.NewPrice;
            _stockDbContext.Stocks.Update(stock);
            await _stockDbContext.SaveChangesAsync();

            _stockDbContext.StocksHistory.Add(stockUpdate);
            int res = await _stockDbContext.SaveChangesAsync();
            return res == 1;
        }
    }
}
