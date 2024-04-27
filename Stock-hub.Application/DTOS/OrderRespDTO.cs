using Stock_hub.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.DTOS
{
    public class OrderRespDTO
    {
        public string Symbol { get; set; }

        public int Quantity { get; set; }

        public OrderType OrderType { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
