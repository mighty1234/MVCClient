using DTOLibrary;
using MVCDataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            var result = OrderLoader.GetOrders();
            foreach (var item in result)
            {
                item.Client = ClientLoader.GetInsertedById((item.Client_id).GetValueOrDefault());
                item.Brunch = BrunchLoader.GetInsertedById((item.Brunch_id).GetValueOrDefault());
                item.Staff = StaffLoader.GetInsertedById((item.Staff_id).GetValueOrDefault());
                item.Gifts = GiftsLoader.GetInsertedById((item.Gift_id).GetValueOrDefault());

            }
            return View(result);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.Staff =StaffLoader.GetAll();
            ViewBag.Gifts = GiftsLoader.GetGifts();
            ViewBag.Brunches = BrunchLoader.GetBrunches();
            ViewBag.Clients = ClientLoader.GetAll();



            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(OrdersDto order)
        {
            try
            {
                // TODO: Add insert logic here
                OrderLoader.Save(order);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Staff = StaffLoader.GetAll();
            ViewBag.Gifts = GiftsLoader.GetGifts();
            ViewBag.Brunches = BrunchLoader.GetBrunches();
            ViewBag.Clients = ClientLoader.GetAll();

            return View();
        }

        // POST: Orders/Edit/5
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

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orders/Delete/5
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
