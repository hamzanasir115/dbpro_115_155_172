using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Views
{
    public class TreatmentController : Controller
    {
        // GET: Treatment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTreatment()
        {
            DB50Entities dbo = new DB50Entities();
            List<string> DiseaseName = new List<string>();
            List<int> Ids = new List<int>();
            foreach (Disease d in dbo.Diseases)
            {
                if (d.DiseaseID != null)
                {
                    Ids.Add(d.DiseaseID);
                    DiseaseName.Add(d.Name);

                }
            }
            ViewBag.DName = DiseaseName;
            ViewBag.Ids = Ids;

            List<int> CIds = new List<int>();
            List<string> CategoryName = new List<string>();
            foreach (Category c in dbo.Categories)
            {
                if (c.CategoryID != null)
                {
                    CIds.Add(c.CategoryID);
                    CategoryName.Add(c.Type);

                }
            }
            ViewBag.CName = CategoryName;
            ViewBag.CIds = CIds;

            return View();
        }
        [HttpPost]
        public ActionResult AddTreatment(Treatment model, int Name,int Type)
        {
            DB50Entities dbo = new DB50Entities();
            Treatment treatment = new Treatment();
            treatment.DiseaseID = Name;
            treatment.CategoryID = Type;
            treatment.TreatmentName = model.TreatmentName;
            treatment.Detail = model.Detail;
            dbo.Treatments.Add(treatment);
            dbo.SaveChanges();
            return RedirectToAction("AddTreatment");
        }

        public ActionResult ViewTreatment()
        {
            ViewBag.Title = "علاج ملاحظہ کريں";
            DB50Entities db = new DB50Entities();
            return View(db.Treatments);
        }
        // GET: Treatment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Treatment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Treatment/Create
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

        // GET: Treatment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Treatment/Edit/5
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

        // GET: Treatment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Treatment/Delete/5
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
