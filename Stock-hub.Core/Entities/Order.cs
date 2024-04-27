using Stock_hub.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [ForeignKey("Stock")]
        public string Symbol { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public OrderType OrderType { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        public Stock Stock { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
