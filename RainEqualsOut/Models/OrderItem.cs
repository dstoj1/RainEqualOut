using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Display(Name = "Order Id")]
        public int OrderId { get; set; }
        [Display(Name = "Item")]
        public string Item { get; set; }
        [Display(Name = "Total Of Each Item")]
        public int TotalOfEachItem { get; set; }

        public ApplicationUser User { get; set; }
    }
}