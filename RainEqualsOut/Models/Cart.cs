using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public string User_Id { get; set; }
        [Display(Name = "Item")]
        public string Item { get; set; }
        [Display(Name = "Quantity")]
        public string Quantity { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public IEnumerable<Inventory> NameOfInventory { get; set; }

        public ApplicationUser User { get; set; }
    }
}