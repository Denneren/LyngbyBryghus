using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dropdown.Factories;

namespace dropdown.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            FacSelect objSelect = new FacSelect();

            ViewBag.Options = objSelect.CreateSelectOptions();

            return View();
        }
        [HttpPost]
        public ActionResult Index(string Værdier)
        {





            //public ActionResult Select(string DropDown)
            //{
            //    ViewBag.Options = objSelect.CreateSelectOptions();
            //    ViewBag.Msg = "Du har vlagt" + DropDown + "i din select";
            //    return View();
            //}

            //string output = "";

            //if (Værdier == "Værdier1")
            //{
            //    output = "Du har valgt Værdi1";
            //}
            //else if (Værdier == "Værdier2")
            //{
            //    output = "Du har valgt Værdi2";
            //}
            //else if (Værdier == "Værdier3")
            //{
            //    output = "Du har valgt Værdi3";
            //}



            //ViewBag.Msg = output;
            return View();
        }
    }
}