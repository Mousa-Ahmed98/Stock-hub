using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.DTOS
{
    public class StockUpdateDto
    {
        [Required]
        public string Symbol { get; set; }

        [Required]
        public decimal CurrentPrice { get; set; }

        [Required]
        public decimal NewPrice { get; set; }
    }
}
