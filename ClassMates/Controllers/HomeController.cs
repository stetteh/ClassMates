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
            List<classmates> members  = new List<classmates>();
            members.Add();


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