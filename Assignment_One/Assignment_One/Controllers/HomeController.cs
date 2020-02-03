using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_One.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //takes method name as the page name which is an action
        {
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

            return View(); //action result = view 
        }
    }
}