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
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockUpdate> StocksHistory { get; set; }
        public DbSet<Order> Orders { get; set; }

        public StockDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<Stock> stocks = new List<Stock>();
            stocks.Add(new Stock
            {
                Symbol = "AAPL",
                CurrentPrice = 12.34M,
                TimeStamp = DateTime.Now,
            });

            stocks.Add(new Stock
            {
                Symbol = "GOOGL",
                CurrentPrice = 15.19M,
                TimeStamp = DateTime.Now,
            });

            stocks.Add(new Stock
            {
                Symbol = "MSFT",
                CurrentPrice = 102.11M,
                TimeStamp = DateTime.Now,
            });

            stocks.Add(new Stock
            {
                Symbol = "AMZN",
                CurrentPrice = 98.4M,
                TimeStamp = DateTime.Now,
            });

            stocks.Add(new Stock
            {
                Symbol = "TSLA",
                CurrentPrice = 211.02M,
                TimeStamp = DateTime.Now,
            });

            builder.Entity<Stock>().HasData(stocks);
        }

    }
}
