using DTOLibrary;
using MVCDataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class GiftController : Controller
    {
        // GET: Gift
        public ActionResult Index()
        {
            var gifts = GiftsLoader.GetGifts();
            return View(gifts);
        }

        // GET: Gift/Details/5
        public ActionResult Details(int id)
        {
            var Gift = GiftsLoader.GetGift(id);
            return View(Gift);
        }

        // GET: Gift/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gift/Create
        [HttpPost]
        public ActionResult Create(GiftsDto gift)
        {
            try
            {
                GiftsLoader.Save(gift);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gift/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gift/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, GiftsDto gift)
        {
            try
            {
               
                GiftsLoader.Save(gift);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      

      // Gift/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                GiftsLoader.Delete(id);
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
