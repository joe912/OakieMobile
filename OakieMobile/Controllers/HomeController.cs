using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OakieMobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "The Oakie....";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the Oakie...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the Oakie...";

            return View();
        }

        public ActionResult NextMatch()
        {
            ViewBag.Message = "Next match.";

            return View();
        }        
        
        public ActionResult Fixtures()
        {
            ViewBag.Message = "Fixtures.";

            return View();
        }
    }
}
