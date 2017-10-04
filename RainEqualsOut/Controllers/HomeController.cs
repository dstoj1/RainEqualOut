using RainEqualsOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RainEqualsOut.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;
        public HomeController()
        {
            context = new ApplicationDbContext();

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Little Background How Rain=Out Got Started.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult Return()
        {
            ViewBag.Message =  "Rain=Out Return Policy.";

            return View();
        }
        public ActionResult Terms()
        {
            ViewBag.Message = "Rain=Out Terms and Conditions.";

            return View();
        }
    }
}