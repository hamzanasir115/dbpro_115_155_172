﻿using MediaEncyclopediaInUrdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class DiseaseController : Controller
    {
        public ActionResult AddDisease()
        {
            DB50Entities db = new DB50Entities();
            List<string> SymptomName = new List<string>();
            List<int> Ids = new List<int>();
            foreach(Symptom d in db.Symptoms)
            {
                if (d.SymptomID != null)
                {
                    Ids.Add(d.SymptomID);
                    SymptomName.Add(d.Name);

                }
            }
            ViewBag.DName = SymptomName;
            ViewBag.Id = Ids;
            return View();
        }

        [HttpPost]
        public ActionResult AddDisease(Diseases model)
        {
            DB50Entities dbo = new DB50Entities();
            Disease disease = new Disease();
            disease.Name = model.Name;
            disease.Detail = model.Detail;
            
            int DiseaseId, SymptomId = 0;
            foreach(var dis in dbo.Diseases)
            {
                if(dis.Name == model.Name && dis.Detail == model.Detail)
                {
                    DiseaseId = dis.DiseaseID;
                    break;
                }
            }
            foreach(var sym in dbo.Symptoms)
            {
                if(sym.Name == model.SymptomName)
                {
                    SymptomId = sym.SymptomID;
                }
            }
            disease.SymptomID = SymptomId;
            dbo.Diseases.Add(disease);

            dbo.SaveChanges();

            return View(model);
        }
        public ActionResult ViewDisease()
        {
            ViewBag.Title = "بيمارياں ملاحظہ کريں";
            DB50Entities db = new DB50Entities();
            return View(db.Diseases);
        }
        public ActionResult UpdateDisease(int id)
        {
            ViewBag.Title = " درستگی ";
            using (DB50Entities db = new DB50Entities())
            {

                return View(db.Diseases.Where(x => x.DiseaseID == id).Single());
            }
        }
        [HttpPost]
        public ActionResult UpdateDisease(Disease obj, int id)
        {
            try
            {
                using (DB50Entities db = new DB50Entities())
                {
                    db.Diseases.Find(id).Name = obj.Name;
                    db.Diseases.Find(id).Detail = obj.Detail;
                    db.SaveChanges();
                }
                return View("AddDisease");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteDisease(int id)
        {
            ViewBag.Title = "اخراج";
            DB50Entities db = new DB50Entities();
            Disease c = db.Diseases.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult DeleteDisease(int id, Disease obj)
        {
            try
            {
                DB50Entities db = new DB50Entities();
                var ToDelete = db.Diseases.Single(x => x.DiseaseID == id);
                db.Diseases.Remove(ToDelete);
                db.SaveChanges();
                return View("AddDisease");
            }
            catch
            {
                return View();
            }
        }
  
    // GET: Disease
    public ActionResult Index()
        {
            return View();
        }

        // GET: Disease/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Disease/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disease/Create
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

        // GET: Disease/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Disease/Edit/5
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

        // GET: Disease/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Disease/Delete/5
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
