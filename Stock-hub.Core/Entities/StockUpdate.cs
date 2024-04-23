using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Core.Entities
{
    public class StockUpdate
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Stock")]
        public string Symbol { get; set; }

        [Required]
        public decimal CurrentPrice { get; set; }

        [Required]
        public decimal NewPrice { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        public Stock Stock { get; set; }
    }
}
