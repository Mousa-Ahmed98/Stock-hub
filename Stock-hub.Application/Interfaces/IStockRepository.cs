using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Interfaces
{
    public interface IStockRepository
    {
        Task<IReadOnlyList<Stock>> GetAllStocks();
        Task<Stock> AddStock(Stock stock);
        Task<bool> UpdateStock(StockUpdate stockUpdate);
        Task<IReadOnlyList<StockUpdate>> GetStockHistory(string symbol);
    }
}
