using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContoscoUniversity.ViewModels;
using ContoscoUniversity.DAL;

namespace ContoscoUniversity.Controllers
{
    public class HomeController : Controller
    {
       private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Students Data Statistics";

            var query = from students in db.Students
                        group students by students.EnrollmentDate into g
                        select new EnrollmentDateGroup
                        {
                            EnrollmentDate = g.Key,
                            StudentCount = g.Count()
                        };



            return View(query.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}