using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;


namespace car.Controllers
{
    public class HpController : Controller
    {
        HpFactory HpFac = new HpFactory();
        // GET: Brand
        public ActionResult Index()
        {
            return View(HpFac.GetAll());
        }
    }
}