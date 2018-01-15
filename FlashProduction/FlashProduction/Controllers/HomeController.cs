using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Duser;
using FlashRepo.Factories;
using FlashRepo.Models;
using FlashProduction.ViewModels;

namespace FlashProduction.Controllers
{
    public class HomeController : Controller
    {

        EgotableFac egoFac = new EgotableFac();

        Egotable2Fac egoFac2 = new Egotable2Fac();

        ProgrammerFac ProFac = new ProgrammerFac();



        // GET: Home
        public ActionResult Index()
        {
            ForsideModel forside = new ForsideModel();

            forside.egoTables = egoFac.GetAll();
            forside.egoTables2 = egoFac2.GetAll();
            forside.proTabels = ProFac.GetAll();


            return View(forside);
        }

        public ActionResult Projekter()
        {
            return View();
        }

        public ActionResult Visuel()
        {
            return View();
        }

        public ActionResult Musik()
        {
            return View();
        }

        public ActionResult VisuelBilleder()
        {
            return View();
        }

        public ActionResult VisuelFoto()
        {
            return View();
        }
        public ActionResult VisuelWebsite()
        {
            return View();
        }
        public ActionResult VisuelVideo()
        {
            return View();
        }

        public ActionResult MusikAudio()
        {
            return View();
        }

        public ActionResult MusikVideo()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }



    }
}