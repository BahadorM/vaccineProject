using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace Vaccine.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork db = new UnitOfWork();
        public ActionResult Index()
        {
            ViewBag.States = db.StatesRepository.GetAllStates();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Users user)
        {
            if (ModelState.IsValid)
            {
                
                db.UserRepository.Insert(user);
                db.Save();

                ViewBag.States = db.StatesRepository.GetAllStates();
                return View();
            }
            else
            {
                return View();
            }
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