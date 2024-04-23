using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stock_hub.Application.DTOS;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;
using System.Security.Claims;

namespace Stock_hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService, UserManager<ApplicationUser> userManager)
        {
            _orderService = orderService;
            _userManager = userManager;
        }

        [HttpPost("Order")]
        public async Task<IActionResult> Add(OrderDto orderDto)
        {
            return Ok(await _orderService.AddOrder(orderDto));
        }

        [HttpGet("Orders")]
        public async Task<IActionResult> Get()
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Ok(await _orderService.GetOrders(userId!));
        }
    }
}
