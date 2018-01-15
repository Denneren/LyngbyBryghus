using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Factories;

namespace car.Controllers
{
    public class HomeController : Controller
    {
        CarFactory CarFac = new CarFactory();
        BrandFactory BrandFac = new BrandFactory();
        ColorFactory ColorFac = new ColorFactory();
        HpFactory HpFac = new HpFactory();

        // GET: Home
        public ActionResult Index()
        {
            return View(CarFac.GetAllJoin());
        }

        public ActionResult AddNew()
        {
            CarOptions dropdownOptions = new CarOptions();

            dropdownOptions.Brands = BrandFac.GetAll();
            dropdownOptions.Colors = ColorFac.GetAll();
            dropdownOptions.Hps = HpFac.GetAll();

            return View(dropdownOptions);

        }
        public ActionResult Edit(int ID)
        {
            CarOptions EditCar = new CarOptions();

            EditCar.Brands = BrandFac.GetAll();
            EditCar.Colors = ColorFac.GetAll();
            EditCar.Hps = HpFac.GetAll();
            EditCar.car = CarFac.GetByID(ID);

            return View(EditCar);
        }
    }

}