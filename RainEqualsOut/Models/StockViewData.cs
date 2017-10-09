using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class StockViewData
    {
        public List<Inventory> InventoryList { get; set; }
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
    }
}