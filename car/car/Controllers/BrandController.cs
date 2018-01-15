using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using Repository.Models;


namespace car.Controllers
{
    public class BrandController : Controller
    {
        BrandFactory BrandFac = new BrandFactory();
        // GET: Brand
        public ActionResult Index()
        {
            return View(BrandFac.GetAll());
        }

        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(Brand input)
        {
            BrandFac.AddNew(input);
            return Redirect("/Brand/Index");
        }
        public ActionResult Delete(int ID)
        {
            BrandFac.Delete(ID);
            return Redirect("/Brand/Index");
        }
    }
}