using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationTestForGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact2()
        {
            //change #2
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact3()
        {
            //change  for branch Feature1.1
            //change #2 for this branch 
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact4()
        {
           //changes for now
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact5()
        {
            //changes for now
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
