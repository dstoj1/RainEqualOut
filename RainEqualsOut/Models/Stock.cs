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
        public string Iventory_Id { get; set; }
        [Display(Name = "Total of Each ")]
        public string TotalOfEach { get; set; }

        public ApplicationUser User { get; set; }
        public Inventory Inventory { get; set; }
    }
}