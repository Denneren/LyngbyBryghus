using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using opgave.Factories;

namespace opgave.Controllers
{


    public class OpgaveController : Controller
    {
        FacSelect objSelect = new FacSelect();


        public ActionResult Select()
        {
            ViewBag.Options = objSelect.CreateSelectOptions();

            return View();
        }

        [HttpPost]
        public ActionResult Select(string DropDown)
        {
            ViewBag.Options = objSelect.CreateSelectOptions();
            ViewBag.Msg = objSelect.CreateSelectResponse(DropDown);

            return View();
        }



    }

}
}
}