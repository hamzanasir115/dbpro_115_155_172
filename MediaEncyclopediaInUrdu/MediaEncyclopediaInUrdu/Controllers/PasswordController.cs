﻿using MediaEncyclopediaInUrdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class PasswordController : Controller
    {
        // GET: Password
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(Password pass)
        {
            DB50Entities db = new DB50Entities();
            foreach(var user in db.Accounts.ToList())
            {
                if(user.Email == Session["Email"].ToString())
                {
                    if(user.Password == pass.OldPassword)
                    {
                        if(pass.NewPassword == pass.ConfirmPassword)
                        {
                            db.Accounts.Find(user.Id).Password = pass.NewPassword;
                            db.SaveChanges();
                            return RedirectToAction("UserProfile", "Manage");
                        }
                    }
                }
            }
            return View();
        }

        // GET: Password/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Password/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Password/Create
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

        // GET: Password/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Password/Edit/5
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

        // GET: Password/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Password/Delete/5
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
