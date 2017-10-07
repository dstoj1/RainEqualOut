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

        [Display(Name = "Total of Each ")]
        public int TotalOfEach { get; set; }

        public Inventory Inventory { get; set; }
        //public IEnumerable<Inventory> NameOfInventory { get; set; }

    }
}