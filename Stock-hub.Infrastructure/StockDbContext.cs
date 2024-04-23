using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stock_hub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Infrastructure
{
    public class StockDbContext : IdentityDbContext<ApplicationUser>
    {
        public StockDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Stock> Stocks { get; set; }
    }
}
