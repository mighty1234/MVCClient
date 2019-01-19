using DTOLibrary;
using MVCDataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
      
        public ActionResult Index()
        {
           var positions= PositionLoader.GetAll();            

            return View(positions);
        }

        // GET: Position/Details/5
        public ActionResult Details(int id)
        {
            
            var result = PositionLoader.GetById(id);
          

            return View(result);
        }

        // GET: Position/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Position/Create
        [HttpPost]
        public ActionResult Create(PositionDto  position)
        {
            try
            {
               PositionLoader.Save(position);
                TempData["SuccessMessage"] = "Created Successfully";
                // TODO: Add insert logic here

                return RedirectToAction("Index");

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Position/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Position/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PositionDto position)
        {
            try
            {

                PositionLoader.Save(position);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        //  Position/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                PositionLoader.Delete(id);
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
