using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace anyklubben.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nyheder()
        {
            return View();
        }

        public ActionResult Bestyrelse()
        {
            return View();
        }

        public ActionResult Klubbenshistorie()
        {
            return View();
        }

        public ActionResult Åbningstider()
        {
            return View();
        }
        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }

    }
}