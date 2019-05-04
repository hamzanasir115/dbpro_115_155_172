using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBook()
        {
            return View();
        }

        public ActionResult GenerateReport1()
        {
            DB50Entities db = new DB50Entities();
            var c = db.Report1();

            CrystalReport1 r = new CrystalReport1();
            r.Load();
            
            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }

        public ActionResult GenerateReport2()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report2();
            CrystalReport2 r = new CrystalReport2();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }

        public ActionResult GenerateReport3()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report3();
            CrystalReport3 r = new CrystalReport3();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }

        public ActionResult GenerateReport4()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report4();
            CrystalReport4 r = new CrystalReport4();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }

        public ActionResult GenerateReport5()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report5();
            CrystalReport5 r = new CrystalReport5();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }
        public ActionResult GenerateReport6()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report11();
            CrystalReport11 r = new CrystalReport11();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }
        public ActionResult GenerateReport7()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report12();
            CrystalReport12 r = new CrystalReport12();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }

        public ActionResult GenerateReport8()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report8();
            CrystalReport8 r = new CrystalReport8();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }

        public ActionResult GenerateReport9()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report9();
            CrystalReport9 r = new CrystalReport9();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }
        public ActionResult GenerateReport10()
        {
            DB50Entities db = new DB50Entities();

            var c = db.Report10();
            CrystalReport10 r = new CrystalReport10();
            r.Load();

            Stream s = r.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            return File(s, "application/pdf");
        }
        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
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

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
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

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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
