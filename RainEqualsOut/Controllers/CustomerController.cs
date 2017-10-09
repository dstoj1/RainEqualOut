using Microsoft.AspNet.Identity;
using RainEqualsOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RainEqualsOut.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext context;
        public CustomerController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Details()
        //{
        //    string UserName = User.Identity.GetUserName();
        //    var user = from x in context.Users where x.UserName == UserName select x;
        //    try { var CurrentUser = user.First(); } catch()
        //    var items = (from x in context.Inventories where x.User.Id == CurrentUser.Id select x).ToList();
        //    List<Inventory> model = new List<Inventory>();
        //    return View();
        //}
    }
}