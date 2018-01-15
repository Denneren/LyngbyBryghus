using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(string Navn, string Efternavn)
        //{
        //    ViewBag.ged = "Dit navn er " + Navn + " " + Efternavn;

        //    return View("output");
        //}

        [HttpPost]
        public ActionResult Index(string img)
        {
            if (img == "1")
            {
                ViewBag.ja = "af5.jpg";
            }
            else if (img == "2")
            {
                ViewBag.ja = "face2.jpg";
            }
            else if (img == "3")
            {
                ViewBag.ja = "face3.jpg";
            }
            else if (img == "4")
            {
                ViewBag.ja = "gif.gif";
            }


            return View("output");
        }

       
    }
}