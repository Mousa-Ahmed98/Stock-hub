using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Stock_hub.Application.DTOS;
using Stock_hub.Application.Hubs;
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
        private readonly IHubContext<RealTimeHub> realTimeHub;

        public StockService(IStockRepository stockRepository, IMapper mapper
            , IHubContext<RealTimeHub> realTimeHub)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
            this.realTimeHub = realTimeHub;
        }

        public async Task<Stock> AddStock(Stock stock)
        {
            return await _stockRepository.AddStock(stock);
            
        }

        public async Task<IReadOnlyList<Stock>> GetAllStocks()
        {
            return await _stockRepository.GetAllStocks();
        }

        public async Task<IReadOnlyList<string>> GetOnlySymbols()
        {
            return await _stockRepository.GetOnlySymbols();
        }

        public async Task<IReadOnlyList<StockUpdateRespDTO>> GetStockHistory(string symbol)
        {
            IReadOnlyList<StockUpdate> res = await _stockRepository.GetStockHistory(symbol);
            IReadOnlyList<StockUpdateRespDTO> history = _mapper.Map<IReadOnlyList<StockUpdateRespDTO>>(res);
            return history;
        }

        public async Task<bool> UpdateStock(StockUpdateReqDto stockUpdateDto)
        {
            StockUpdate stockUpdate = _mapper.Map<StockUpdate>(stockUpdateDto);
            stockUpdate.TimeStamp = DateTime.Now;

            bool res = await _stockRepository.UpdateStock(stockUpdate);
            if(res == true)
            {
                StockUpdateRespDTO stockUpdateRespDto = _mapper.Map<StockUpdateRespDTO>(stockUpdate);
                await realTimeHub.Clients.All.SendAsync("NotifyPriceUpdated", stockUpdateRespDto);
            }
            return res;
        }
    }
}
