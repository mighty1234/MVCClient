using DTOLibrary;
using MVCDataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            var result = ClientLoader.GetAll();
            return View(result);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var result = ClientLoader.GetById(id);
            return View(result);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(ClientDto  client)
        {
            try
            {
                ClientLoader.Save(client);
                TempData["SuccessMessage"] = "Created Successfully";
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClientDto client)
        {
            try
            {
                ClientLoader.Save(client);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        

      //  Client/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                ClientLoader.Delete(id);
  TempData["SuccessMessage"] = "Created Successfully";
                return RedirectToAction("Index");
              
            }
            catch
            {
                return View();
            }
        }
    }
}
