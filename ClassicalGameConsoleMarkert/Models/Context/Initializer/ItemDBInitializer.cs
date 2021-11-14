using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClassicalGameConsoleMarkert.Models.Context.Initializer
{
    public class ItemDBInitializer: DropCreateDatabaseAlways<MarketContext>
    {
        protected override void Seed(MarketContext context)
        {
            context.Items.Add(new Item { ItemID = 1, Name = "PlayStation 2", Price = 70.2m });
            context.Items.Add(new Item { ItemID = 2, Name = "PlayStation 1", Price = 30.50m });
            context.Items.Add(new Item { ItemID = 3, Name = "PlayStationPortable 2000", Price = 30m });

            base.Seed(context);
        }
    }
}