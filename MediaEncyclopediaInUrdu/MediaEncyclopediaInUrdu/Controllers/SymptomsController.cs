using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class SymptomsController : Controller
    {
        // GET: Symptoms
        public ActionResult AddSymptoms()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSymptoms(Symptom model)
        {
            DB50Entities dbo = new DB50Entities();
            Symptom symptom = new Symptom();
            symptom.Name = model.Name;
            symptom.Detail = model.Detail;
            symptom.Reason = model.Reason;
            dbo.Symptoms.Add(symptom);
            dbo.SaveChanges();
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Symptoms/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Symptoms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Symptoms/Create
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

        // GET: Symptoms/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Symptoms/Edit/5
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

        // GET: Symptoms/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Symptoms/Delete/5
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
