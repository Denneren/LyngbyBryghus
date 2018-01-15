using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using udregning.Factories;

namespace udregning.Controllers
{
    public class HomeController : Controller
    {
        FactoryGeometri geometri = new FactoryGeometri();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UdregnKugleoverflade()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UdregnKugleoverflade(string input, string knap)
        {
            string resultat = "";

            resultat = geometri.KugleOverflade(input, knap);
            ViewBag.Resultat = resultat;

            return View();
        }
        [HttpPost]
        public ActionResult UdregnKugleRumfang(string input, string knap)
        {
            string resultat = "";

            resultat = geometri.KugleRumfang(input, knap);
            ViewBag.Resultat = resultat;

            return View("Index");
        }

        public ActionResult PyramideRumfang()
        {


            return View();
        }

        [HttpPost]
        public ActionResult PyramideRumfang(string input, string input2)
        {
            string resultat = "";

            resultat = geometri.PyramideRumfang(input, input2);
            ViewBag.Resultat = resultat;

            return View();
        }

        public ActionResult KegleRumfang()
        {


            return View();
        }
        [HttpPost]
        public ActionResult KegleRumfang(string input, string input2)
        {
            string resultat = "";

            resultat = geometri.PyramideRumfang(input, input2);
            ViewBag.Resultat = resultat;

            return View();
        }

        public ActionResult PrismerRumfang()
        {


            return View();
        }

        [HttpPost]
        public ActionResult PrismerRumfang(string input, string input2)
        {
            string resultat = "";
            resultat = geometri.PrismerRumfang(input, input2);
            ViewBag.Resultat = resultat;

            return View();

        }

        public ActionResult CylinderRumfang()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CylinderRumfang(string inputR, string inputH, string knap)
        {
            string resultat = "";

            resultat = geometri.CylinderRumfang(inputR, inputH, knap);
            ViewBag.Resultat = resultat;

            return View();
        }

        public ActionResult Kasse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kasse(string inputH, string inputL, string inputB, string knap)
        {
            string resultat = "";

            resultat = geometri.Kasse(inputH, inputL, inputB, knap);
            ViewBag.Resultat = resultat;

            return View();
        }

        public ActionResult Cirkel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cirkel(string inputR, string inputD, string knap)
        {
            string resultat = "";

            resultat = geometri.Cirkel(inputR, inputD, knap);
            ViewBag.Resultat = resultat;

            return View();
        }


        public ActionResult Parallelogram()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Parallelogram(string inputH, string inputG)
        {
            string resultat = "";

            resultat = geometri.Parallelogram(inputH, inputG);
            ViewBag.Resultat = resultat;

            return View();
        }


        public ActionResult TrekantAreal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TrekantAreal(string inputH, string inputG)
        {
            string resultat = "";

            resultat = geometri.TrekantAreal(inputH, inputG);
            ViewBag.Resultat = resultat;

            return View();
        }


        //public ActionResult TrekantHeron()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult TrekantHeron(string inputA, string inputB, string inputC)
        {
            string resultat = "";

            resultat = geometri.TrekantHeron(inputA, inputB, inputC);
            ViewBag.Resultat = resultat;

            return View("TrekantAreal");
        }

        public ActionResult Trapez()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Trapez(string inputA, string inputB, string inputH)
        {
            string resultat = "";

            resultat = geometri.Trapez(inputA, inputB, inputH);
            ViewBag.Resultat = resultat;

            return View();
        }

        public ActionResult Rektangel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Rektangel(string inputL, string inputB, string knap)
        {
            string resultat = "";

            resultat = geometri.Rektangel(inputL, inputB, knap);
            ViewBag.Resultat = resultat;

            return View();
        }
    }
}





