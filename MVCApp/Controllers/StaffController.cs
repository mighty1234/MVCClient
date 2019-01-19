using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTOLibrary;
using MVCDataLoader;

namespace MVCApp.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            var list = StaffLoader.GetAll();
            foreach (var item in list)
            {
                item.Brunch = BrunchLoader.GetInsertedById(item.Brunch_id);
                item.Position = PositionLoader.GetInsertedById(item.Position_id);
            }
            return View(list);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            var item = StaffLoader.GetById(id);


            return View(item);
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            ViewBag.Positions = PositionLoader.GetAll();
            ViewBag.Brunches = BrunchLoader.GetBrunches();
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(StaffDto staff)
        {
            try
            {

                StaffLoader.Save(staff);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.Positions = PositionLoader.GetAll();
            ViewBag.Brunches = BrunchLoader.GetBrunches();
            return View();
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StaffDto staff)
        {
            try
            {
                if (id == staff.Id)
                {
                    TempData["SuccessMessage"] = "Updated Successfully";
                    StaffLoader.Save(staff);
                }
                else
                {
                    TempData["FailMessage"] = "Updated Failed";
                    return View();
                }
              
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            StaffLoader.Delete(id);
            return View();
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StaffDto staff)
        {
            try
            {
                StaffLoader.Save(staff);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
