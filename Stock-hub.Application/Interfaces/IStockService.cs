using Stock_hub.Application.DTOS;
using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Interfaces
{
    public interface IStockService
    {
        Task<IReadOnlyList<Stock>> GetAllStocks();
        Task<Stock> AddStock(Stock stock);
        Task<bool> UpdateStock(StockUpdateReqDto stockUpdateDto);
        Task<IReadOnlyList<StockUpdateRespDTO>> GetStockHistory(string symbol);
        Task<IReadOnlyList<string>> GetOnlySymbols();
    }
}
