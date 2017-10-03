using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        public int Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        //public Vendor Vendor { get; set; }
        //public int VendorID { get; set; }
        //public IEnumerable<Vendor> NameOfVendor { get; set; }
        public ApplicationUser User { get; set; }
        //public bool ApproveRequest { get; set; }
    }
}