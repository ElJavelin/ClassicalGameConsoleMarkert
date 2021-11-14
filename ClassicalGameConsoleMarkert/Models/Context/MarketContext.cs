using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalGameConsoleMarkert.Models
{
    public class MarketContext: DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Trade> Trades { get; set; }
    }
}
