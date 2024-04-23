using Stock_hub.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.DTOS
{
    public class OrderDto
    {
        [Required]
        public string Symbol { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public OrderType OrderType { get; set; }
    }
}
