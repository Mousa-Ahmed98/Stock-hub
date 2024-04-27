using Stock_hub.Application.DTOS;
using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Interfaces
{
    public interface IOrderService
    {
        Task<Order> AddOrder(OrderDto orderDto, string userId);
        Task<IReadOnlyList<OrderRespDTO>> GetOrders(string UserId);
    }
}
