using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetalnewsRepo.Factories;
using MetalnewsRepo.Models;

namespace Metalnews.Controllers
{
    public class HomeController : Controller
    {
        KunstnereFactory KunstFac = new KunstnereFactory();
        MetalFactory MetalFac = new MetalFactory();
        // GET: Home
        public ActionResult Index()
        {
            return View(MetalFac.GetAllJoin());
        }

        public ActionResult Details(int ID)
        {
            return View(MetalFac.GetDetails(ID));
        }
        public ActionResult addnew()
        {
            Metaloptions DropDown = new Metaloptions();
            DropDown.Artist = KunstFac.GetAll();

            return View(DropDown);
        }

        [HttpPost]
        public ActionResult addnew(Metal input)
        {
            MetalFac.AddNew(input);
            return Redirect("/Home/Index");
        }
        public ActionResult Delete(int ID)
        {
            MetalFac.Delete(ID);
            return Redirect("/Home/Index");
        }
    }

}