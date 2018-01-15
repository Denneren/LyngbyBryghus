using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LbRepo.Factories;
using LbRepo.Models;

namespace Lyngby_Bryghus.Areas.CMS.Controllers
{
    public class HomeController : Controller
    {

        int Admin = 2;
        int Editor = 1;
        // GET: CMS/Home
        public ActionResult Index()
        {
            if (Session["role"] == null || (int)Session["role"] < Editor)
            {
                return Redirect("/Login");
            }

            return View();
        }

        public ActionResult Nyhed()
        {
            return View();
        }
    }
}