using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class datoController : Controller
    {
        // GET: dato
        public ActionResult Index()
        {
            ViewBag.lokum = DateTime.Now;
            return View();
        }

        [ChildActionOnly]
        public ContentResult Hest()
        {
            string indhold;

            indhold = DateTime.Now + "<br />";

            return Content(indhold);

        }
        public ActionResult Xmas()
        {
            DateTime endTime = new DateTime(2017, 12, 24);
            DateTime startTime = DateTime.Today;

            int countDown = endTime.Subtract(startTime).Days;

            return Content("Der er " + countDown + " dage til Juleaften");
        }
    }

}