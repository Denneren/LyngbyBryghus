using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LbRepo.Factories;
using LbRepo.Models;

namespace Lyngby_Bryghus.Controllers
{
    public class ContentController : Controller

    {
        ContentFac cf = new ContentFac();
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Omos()
        {
            return PartialView(cf.Get(1));
        }
    }
}