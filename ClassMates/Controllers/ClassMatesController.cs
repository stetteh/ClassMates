using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassMates.Models;

namespace ClassMates.Controllers
{
    public class ClassMatesController : Controller
    {
        // GET: ClassMates
        public ActionResult Index()
        {
            List<ClassMate> colleagues = new List<ClassMate>()
            {
                new ClassMate(1, "Seth Quaye", "Black", 5.11f),
                new ClassMate(2, "Brain Stickney", "Black", 5.6f),
                new ClassMate(3, "Zach Ballard", "Brown", 5.5f),
                new ClassMate(4, "Trey", "Black", 5.2f),
                new ClassMate(5, "Kate", "Blonde", 5.6f),
                new ClassMate(6, "Tee", "Black", 5.7f),
                new ClassMate(7, "Kevin", "Black", 5.6f),
                new ClassMate(8, "Daniel", "Black", 5.20f)
            };
            return View(colleagues);
            
        }
    }
}