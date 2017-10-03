using Microsoft.AspNet.Identity;
using RainEqualsOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RainEqualsOut.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext context;
        public AdminController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in context.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            var inventory = from x in context.Inventories where x.User.Id == CurrentUser.Id select x;
            List<Inventory> model = inventory.ToList();

            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Inventory newInventory)
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in context.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            newInventory.User = CurrentUser;
            context.Inventories.Add(newInventory);
            context.SaveChanges();
            return RedirectToAction("Details", "Inventory");
        }
        public ActionResult RemoveVendor(int InventoryId)
        {
            var Vendor = from x in context.Inventories where x.ID == InventoryId select x;
            context.Inventories.Remove(Vendor.First());
            context.SaveChanges();
            return RedirectToAction("Details", "Inventory");
        }
        public ActionResult Edit(int? VendorId)
        {
            if (VendorId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = context.Inventories.Find(VendorId);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            //ViewBag.PickUpDayID = new SelectList(context.PickUpDay, "Id", "DayOfWeek", customer.PickUpDayID);
            //ViewBag.PickUpFrequencyID = new SelectList(context.PickUpFrequency, "Id", "Frequency", customer.PickUpFrequencyID);

            return View(inventory);
        }
    }
}
    
