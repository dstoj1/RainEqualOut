using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RainEqualsOut.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Items Purchased")]
        public string ItemsPurchased { get; set; }
        [Display(Name = "User Id")]
        public int User_Id { get; set; }
        [Display(Name = "'Status")]
        public string  StatusOfDelivery{ get; set; }
        [Display(Name = "Date")]
        public int DateOfPurchase { get; set; }
        [Display(Name = "Total Amount")]
        public int TotalAmount { get; set; }
        [Display(Name = "Payment")]
        public string Pament{ get; set; }
        [Display(Name = "Ship To Address")]
        public string ShipToAddress { get; set; }
       
        public ApplicationUser User { get; set; }

    }
}