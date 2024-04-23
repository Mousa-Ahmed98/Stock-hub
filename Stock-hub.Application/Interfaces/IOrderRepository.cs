using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
        Task<IReadOnlyList<Order>> GetOrders(string UserId);
    }
}
