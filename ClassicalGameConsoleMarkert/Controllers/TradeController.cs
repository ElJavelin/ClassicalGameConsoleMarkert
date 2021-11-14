using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassicalGameConsoleMarkert.Models;

namespace ClassicalGameConsoleMarkert.Controllers
{
    public class TradeController : Controller
    {
        MarketContext db = new MarketContext();

        // GET: Trade
        public ActionResult Index()
        {
            IEnumerable<Item> items = db.Items;
            ViewBag.Items = items;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int ItemID = 0)
        {
            ViewBag.ItemID = ItemID;

            return View();
        }

        [HttpPost]
        public string Buy(Trade trade)
        {
            trade.TradeDate = DateTime.Now;

            db.Trades.Add(trade);

            db.SaveChanges();
            return $"Предмет №{trade.ItemID} был успешно приобретён";
        }
    }
}