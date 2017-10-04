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

        [Display(Name = "Item")]
        public string Item { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public IEnumerable<Inventory> NameOfInventory { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public IEnumerable<Customer> NameOfCustomer { get; set; }

    public ApplicationUser User { get; set; }
    }
}