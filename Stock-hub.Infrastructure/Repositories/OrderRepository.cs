using Microsoft.EntityFrameworkCore;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;
using Stock_hub.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StockDbContext _stockDbContext;

        public OrderRepository(StockDbContext stockDbContext)
        {
            _stockDbContext = stockDbContext;
        }

        public async Task<Order> AddOrder(Order order)
        {
            _stockDbContext.Orders.Add(order);
            await _stockDbContext.SaveChangesAsync();
            return order;
        }

        public async Task<IReadOnlyList<Order>> GetOrders(string UserId)
        {
            return await _stockDbContext.Orders
                .Where(o => o.ApplicationUserId == UserId)
                .ToListAsync();
        }
    }
}
