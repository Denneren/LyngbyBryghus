using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetalnewsRepo.Models;
using MetalnewsRepo.Factories;

namespace Metalnews.Controllers
{
    public class KunstnereController : Controller
    {
        KunstnereFactory KunstFac = new KunstnereFactory();
        // GET: Kunstnere
        public ActionResult Index()
        {
            return View(KunstFac.GetAll());
        }

        public ActionResult addnew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addnew(kunstnere input)
        {
            KunstFac.AddNew(input);
            return Redirect("/kunstnere/Index");
        }

        public ActionResult Delete(int ID)
        {
            KunstFac.Delete(ID);
            return Redirect("/kunstnere/Index");
        }
    }

}