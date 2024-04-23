﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Stock_hub.Application.DTOS;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper
            , UserManager<ApplicationUser> userManager)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Order> AddOrder(OrderDto orderDto)
        {
            Order order = _mapper.Map<Order>(orderDto);
            return await _orderRepository.AddOrder(order);
        }

        public async Task<IReadOnlyList<Order>> GetOrders(string UserId)
        {
            return await _orderRepository.GetOrders(UserId);
        }
    }
}
