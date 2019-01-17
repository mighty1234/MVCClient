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
           var brunch=  BrunchLoader.GetBrunch(id);
            ViewBag.Staff = brunch.Staff;
            ViewBag.Oreder = brunch.Orders;
            return View(brunch);
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
                BrunchLoader.Save(brunch);
                TempData["SuccessMessage"] = "Created Successfully";
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
        public ActionResult Edit(int id, BrunchDto brunch)
        {
            try
            {
                BrunchLoader.Save(brunch);
                TempData["SuccessMessage"] = "Updated Successfully";

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Brunch/Delete/5
        //public ActionResult Delete()
        //{
        //    return View();
        //}


        [HttpGet]
        // POST: Brunch/Delete/5   
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                BrunchLoader.Delete(id);
                TempData["SuccessMessage"] = "Deleted Successfully";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
