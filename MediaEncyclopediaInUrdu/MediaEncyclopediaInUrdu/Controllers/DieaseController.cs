using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class DieaseController : Controller
    {
        // GET: Diease
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDiease()
        {
            return View();
        }



        // GET: Diease/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Diease/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diease/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Diease/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Diease/Edit/5
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

        // GET: Diease/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Diease/Delete/5
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
