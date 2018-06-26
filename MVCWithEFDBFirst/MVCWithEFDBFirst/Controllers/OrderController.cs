using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFDBFirst.Controllers
{
    public class OrderController : Controller
    {
        private MedicineCounterEntities db = new MedicineCounterEntities();

        // GET: Order
        public ActionResult Index(int Id)
        {
            Order order = new Order();
            order.Product = db.Products.Find(Id);
            return View(order);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Index(Order order)
        {
            try
            {
                Product product = db.Products.Find(order.Product.Id);
                order.MedId = order.Product.Id;
                order.Product = product;
                order.TotalPrice = order.OrderQuantity * order.Product.Price;
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index", "Products");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
