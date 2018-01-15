using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LbRepo.Factories;
using LbRepo.Models;

namespace Lyngby_Bryghus.Controllers
{
    public class ProductController : Controller
    {
        ProductFac pf = new ProductFac();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {


            return View(pf.GetAll());
        }
    }


}