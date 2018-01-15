using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LbRepo.Factories;
using LbRepo.Models;
namespace Lyngby_Bryghus.Controllers
{
    public class LoginController : Controller
    {
        UserFac uf = new UserFac();

        // GET: CMS/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(string Username, string Password)
        {
            Users auser = uf.Login(Username, Password);

            if (auser.Username != null)
            {
                Session["id"] = auser.ID;
                Session["role"] = auser.ID;
                ViewBag.Msg = Session["role"];
                return Redirect("/CMS/Home");
            }
            else
            {
                ViewBag.Msg = "<b>Forkert Login<b/>";
                return View();
            }
        }
    }
}