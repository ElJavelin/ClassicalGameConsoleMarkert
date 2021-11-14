using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalGameConsoleMarkert.Models
{
    public class Trade
    {
        public Guid TradeID { get; set; }
        public DateTime TradeDate { get; set; }

        public Guid SellerID { get; set; }
        public Guid BuyerID { get; set; }
        public int ItemID { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
