using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class Stock
    {
        public int ID { get; set; }

        [Display(Name = "Invetory Id")]
        public int Iventory_Id { get; set; }
        [Display(Name = "Total of Each ")]
        public int TotalOfEach { get; set; }

        public ApplicationUser User { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public IEnumerable<Inventory> NameOfInventory { get; set; }

    }
}