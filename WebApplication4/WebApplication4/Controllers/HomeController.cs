using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DateTime endTime = new DateTime(2017, 12, 24);
            DateTime startTime = DateTime.Now;


            int countDown = endTime.Subtract(startTime).Days;

            ViewBag.ja = "Der er " + countDown + " dage til Juleaften";

            return View();
        }
        [HttpPost]

        public ActionResult Index(string talbox1, string talbox2, string knapper)
        {
            double tal1 = Convert.ToDouble(talbox1.Replace(".", ","));
            double tal2 = Convert.ToDouble(talbox2.Replace(".", ","));
            if (knapper == "+")
            {
                ViewBag.udregning = tal1 + tal2;


            }
            else if (
                knapper == "-")
            {
                ViewBag.udregning = tal1 - tal2;
            }
            else if (
                knapper == "*")
            {
                ViewBag.udregning = tal1 * tal2;
            }
            else
            {
                ViewBag.udregning = tal1 / tal2;
            }
            return View();
        }



    }

}