using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        [Display(Name = "Photo")]
        public string Photo { get; set; }
        [Display(Name = "Product")]
        public string Product { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Size")]
        public string Size { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Display(Name = "Price")]
        public int Price { get; set; }
       

        public ApplicationUser User { get; set; }

    }
}