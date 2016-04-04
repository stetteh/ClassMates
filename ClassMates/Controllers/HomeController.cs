using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassMates.Models;

namespace ClassMates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ClassMate> colleagues = new List<ClassMate>()
            {
                new ClassMate(1, "Seth Quaye", "Black", 5.11),
                new ClassMate(2, "Brain Stickney", "Black", 5.5),
                new ClassMate(2, "Zach Ballard", "Brown", 5.4),
                new ClassMate(2, "Trey", "Black", 5.2),
                new ClassMate(2, "Kate", "Blonde", 5.2),
                new ClassMate(2, "Tee", "Black", 5.3),
                new ClassMate(2, "Kevin", "Black", 5.1),
            };
            return View(colleagues);
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