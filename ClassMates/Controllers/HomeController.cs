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

            List<classmates> colleagues = new List<classmates>()
            {
                new classmates(1, "Seth Quaye", "Black", 5.11),
                new classmates(2, "Brain Stickney", "Black", 5.5),
                new classmates(2, "Zach Ballard", "Brown", 5.0),
                new classmates(2, "Trey", "Black", 5.2),
                new classmates(2, "Kate", "Blonde", 5.0),
                new classmates(2, "Tee", "Black", 5.3),
                new classmates(2, "Kevin", "Black", 2.1),
            };
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