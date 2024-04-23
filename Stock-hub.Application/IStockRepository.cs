using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application
{
    public interface IStockRepository
    {
        Task<IReadOnlyList<Stock>> GetAllStocks();
        Task<Stock> AddStock(Stock stock);
    }
}
