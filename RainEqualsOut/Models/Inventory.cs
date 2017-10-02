﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        [Display(Name = "Product")]
        public string Product { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Size")]
        public string Size { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Cost")]
        public string Cost { get; set; }        
    }
}