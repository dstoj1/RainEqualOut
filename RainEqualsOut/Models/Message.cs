using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace RainEqualsOut.Models
{
    public class Message
    {
            public int Id { get; set; }

            [Display(Name = "Message")]
            public string Msg { get; set; }

            public ApplicationUser User { get; set; }
        //    public Vendor Vendor { get; set; }
        //}
    }
}