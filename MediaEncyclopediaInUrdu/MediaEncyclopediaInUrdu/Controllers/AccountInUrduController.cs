using MediaEncyclopediaInUrdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class AccountInUrduController : Controller
    {
        public ActionResult Registered()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registered(Register model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            DB50Entities1 dbo = new DB50Entities1();
            Account account = new Account();
            Profile profile = new Profile();
            account.UserName = model.Name;
            account.Email = model.Email;
            account.Password = model.Password;
            dbo.Accounts.Add(account);
            dbo.SaveChanges();

            profile.Address = model.Address;
            profile.ContactNumber = model.TelephoneNumber;
            profile.Country = model.Country;
            profile.Email = model.Email;
            profile.LicenseNumber = model.LicenseNumber;
            profile.TelephoneNumber = model.TelephoneNumber;
            profile.Type = model.type;
            dbo.Profiles.Add(profile);
            dbo.SaveChanges();
            return View(model);
        }
        // GET: AccountInUrdu
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountInUrdu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountInUrdu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountInUrdu/Create
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

        // GET: AccountInUrdu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountInUrdu/Edit/5
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

        // GET: AccountInUrdu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountInUrdu/Delete/5
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
