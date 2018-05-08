using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace California_State_Polytechnic_University_Pomona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            Session["name"] = ""; 
            ViewBag.Message = "Your application description page.";
            
            return RedirectToAction("Index","play");
        }

        public ActionResult Contact()
        {
            Session["name"] = "nawaf";
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}