using DTOLibrary;
using MVCDataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class BrunchController : Controller
    {
        // GET: Brunch
        public ActionResult Index()
        {

            List<BrunchViewModel> x = BrunchLoader.GetBrunches();
        

            return View(x);
        }

        // GET: Brunch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Brunch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brunch/Create
        [HttpPost]
        public ActionResult Create(BrunchDto brunch)
        {
            try
            {
                var x = brunch;
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Brunch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Brunch/Edit/5
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

        // GET: Brunch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Brunch/Delete/5
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
