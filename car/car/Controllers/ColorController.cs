using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;
using Repository.Models;

namespace car.Controllers
{
    public class ColorController : Controller
    {
        ColorFactory ColorFac = new ColorFactory();
        // GET: Color
        public ActionResult Index()
        {
            return View(ColorFac.GetAll());
        }

        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(Color input)
        {
            ColorFac.AddNew(input);

            return Redirect("/Color/Index/");
        }

        public ActionResult Delete(int ID)
        {
            ColorFac.Delete(ID);
            return Redirect("/Color/Index");
        }

        public ActionResult Edit(int ID)
        {
            return View(ColorFac.GetByID(ID));
        }
    }
}