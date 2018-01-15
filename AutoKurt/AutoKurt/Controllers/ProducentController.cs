using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkRepo;

namespace AutoKurt.Controllers
{
    public class ProducentController : Controller
    {
        ProducentFac pf = new ProducentFac();
        // GET: Producent
        public ActionResult VisProducent()
        {
            return View(pf.Get(1));
        }

        public ActionResult VisProducenter()
        {
            return View(pf.GetAll());
        }
    }
}