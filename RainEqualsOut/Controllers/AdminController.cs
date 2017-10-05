using Microsoft.AspNet.Identity;
using RainEqualsOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return RedirectToAction("Details");
        }
        public ActionResult RemoveProduct(int InventoryId)
        {
            var Vendor = from x in context.Inventories where x.ID == InventoryId select x;
            context.Inventories.Remove(Vendor.First());
            context.SaveChanges();
            return RedirectToAction("Details", "Admin");
        }
        [HttpGet]
        public ActionResult Edit(int? InventoryId)
        {
            if (InventoryId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = context.Inventories.Find(InventoryId);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            //ViewBag.PickUpDayID = new SelectList(context.PickUpDay, "Id", "DayOfWeek", customer.PickUpDayID);
            //ViewBag.PickUpFrequencyID = new SelectList(context.PickUpFrequency, "Id", "Frequency", customer.PickUpFrequencyID);

            return View(inventory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Company,FirstName,LastName,Phone,Email,TypeOfFood,CostPerHour,CostPerPerson,TurnOnOff")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                context.Entry(inventory).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Details");
            }
            return View(inventory);
        }
    }
}
    
