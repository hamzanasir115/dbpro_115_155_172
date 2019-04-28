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
        public ActionResult ViewSymptoms()
        {
            ViewBag.Title = "علامات ملاحظہ کريں";
            DB50Entities db = new DB50Entities();
            return View(db.Symptoms);
        }
        public ActionResult UpdateSymptoms(int id)
        {
            ViewBag.Title = " درستگی ";
            using (DB50Entities db = new DB50Entities())
            {

                return View(db.Symptoms.Where(x => x.SymptomID == id).Single());
            }
        }
        [HttpPost]
        public ActionResult UpdateSymptoms(Symptom obj, int id)
        {
            try
            {
                using (DB50Entities db = new DB50Entities())
                {
                    db.Symptoms.Find(id).Name = obj.Name;
                    db.Symptoms.Find(id).Detail = obj.Detail;
                    db.Symptoms.Find(id).Reason = obj.Reason;
                    db.SaveChanges();
                }
                return View("AddSymptoms");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteSymptoms(int id)
        {
            ViewBag.Title = "اخراج";
            DB50Entities db = new DB50Entities();
            Symptom c = db.Symptoms.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult DeleteSymptoms(int id, Symptom obj)
        {
            try
            {
                DB50Entities db = new DB50Entities();
                var ToDelete = db.Symptoms.Single(x => x.SymptomID == id);
                db.Symptoms.Remove(ToDelete);
                db.SaveChanges();
                return View("AddSymptoms");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FindDisease()
        {

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
