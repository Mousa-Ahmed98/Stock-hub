using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.DTOS
{
    public class StockUpdateRespDTO
    {
        public int Id { get; set; }

        public string Symbol { get; set; }

        public decimal OldPrice { get; set; }

        public decimal NewPrice { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
