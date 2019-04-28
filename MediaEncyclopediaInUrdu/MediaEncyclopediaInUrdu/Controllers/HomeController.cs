using MediaEncyclopediaInUrdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaEncyclopediaInUrdu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult HomePage()
        {
            DB50Entities db = new DB50Entities();
            Register reg = new Register();
            List<Register> List_Reg = new List<Register>();
            foreach(var acc in db.Profiles)
            {
                foreach(var account in db.Accounts)
                {
                    if(acc.Email == account.Email)
                    {
                        if(acc.Type == "ڈاکٹر")
                        {
                            reg.Email = acc.Email;
                            reg.Name = account.UserName;
                            reg.ImagePath = acc.ImagePath;
                            reg.Address = acc.Address;
                            reg.Country = acc.Country;
                            reg.TelephoneNumber = acc.TelephoneNumber;
                            reg.type = acc.Type;
                            List_Reg.Add(reg);
                            ViewBag.Doctor = List_Reg;

                        }
                    }
                }
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}