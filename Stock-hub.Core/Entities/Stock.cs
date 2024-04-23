using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Core.Entities
{
    public class Stock
    {
        [Key]
        [Required]
        public string Symbol { get; set; }

        [Required]
        public decimal CurrentPrice { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }


    }
}
