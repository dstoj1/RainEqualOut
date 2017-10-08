using Microsoft.AspNet.Identity;
using RainEqualsOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
            var items = (from x in context.Inventories where x.User.Id == CurrentUser.Id select x).ToList();
            List<Inventory> model = new List<Inventory>();
            foreach(var item in items)
            {
                if (item.IsActive)
                {
                    model.Add(item);
                }
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(InventoryForm Form)
        {
            Inventory newInventory = new Inventory();
            string UserName = User.Identity.GetUserName();
            var user = from x in context.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            string filename = Path.GetFileName(Form.Image.FileName);
            newInventory.Photo = $"../Images/{filename}";
            filename = Path.Combine(Server.MapPath("~/Images/"), filename);
            Form.Image.SaveAs(filename);
            newInventory.User = CurrentUser;
            newInventory.Product = Form.Product;
            newInventory.Description = Form.Description;
            newInventory.Size = Form.Size;
            newInventory.Color = Form.Color;
            newInventory.Type = Form.Type;
            newInventory.Price = Form.Price;
            newInventory.IsActive = true;
            context.Inventories.Add(newInventory);
            Stock newStock = new Stock();
            newStock.Inventory = newInventory;
            newStock.TotalOfEach = 0;
            context.Stocks.Add(newStock);
            context.SaveChanges();
            return RedirectToAction("Details");
        }
        public ActionResult RemoveProduct(int? id)
        {
            var inventory = from x in context.Inventories where x.ID == (int)id select x;
            inventory.First().IsActive = false;
            context.SaveChanges();
            return RedirectToAction("Details");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventoryForm inventory = new InventoryForm();
            inventory.ID = (int)id;
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
        public ActionResult Edit([Bind(Include = "Product,Description,Size,Color,Type,Price")] InventoryForm inventory)
        {
            if (ModelState.IsValid)
            {
                context.Entry(inventory).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Details");
            }
            return View(inventory);
        }
        [HttpPost]
        public ActionResult AddToStock(int InventoryId)
        {
            var AddingStock = context.Inventories.Where(x => x.ID == InventoryId).First();
            AddingStock.amount++;            
            context.SaveChanges();
            return View();
        }
        public ActionResult ViewStock()
        {
            StockViewData model = new StockViewData();
            var ViewAmountInStock = context.Inventories.ToList();
            model.InventoryList = ViewAmountInStock;
            return View("Stock", model);
        }
    }
}
    
