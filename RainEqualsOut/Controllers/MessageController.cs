using Microsoft.AspNet.Identity;
using RainEqualsOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RainEqualsOut.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private ApplicationDbContext context;
        public MessageController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Message
        public ActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Message message = new Message();
            return View(message);
        }

        [HttpPost]
        public ActionResult Create(Message message)
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in context.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            message.User = CurrentUser;
            if (ModelState.IsValid)
            {
                context.Messages.Add(message);
                context.SaveChanges();
                return RedirectToAction("Success");
            }
            else
            {
                return RedirectToAction("Fail");
            }
        }
    }
}