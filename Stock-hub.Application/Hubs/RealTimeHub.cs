using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Hubs
{
    public class RealTimeHub : Hub
    {
        public async Task UpdatePrice(string symbol, decimal newPrice)
        {
            await Clients.All.SendAsync("NotifyPriceUpdate");
        }
    }
}
