using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webith207_SystemID.Helpers;

namespace webith207_SystemIO.Controllers
{
    public class HomeController : Controller
    {
        FileTools ft = new FileTools();
        DirTools dt = new DirTools();

        // GET: Home
        public ActionResult Index()
        {
            string filePath = Request.PhysicalApplicationPath + "/Views/Home/";
            return View(ft.GetAllFiles(filePath));
        }

        public ActionResult CreateFile()
        {

            ft.LogError("Bacon");
            //ViewBag.Msg = Request.PhysicalApplicationPath;

            return View();
        }
        [HttpPost]
        public ActionResult CreateFile(string fileName)
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/" + fileName;

            ViewBag.Msg = ft.CreateFile(filePath);
            return View();


        }

        public ActionResult DeleteFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteFile(string fileName)
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/" + fileName;

            try
            {
                ViewBag.Msg = ft.DeleteFile(filePath);
            }
            catch (Exception ex)
            {
                ft.LogError("[ERROR]" + ex.Message);
                ViewBag.Msg = "Der opstod en fejl";
            }

            return View();


        }
        public ActionResult MoveFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoveFile(string fileName, string fileMoveFrom, string fileMoveTo)
        {

            string pathFrom = Request.PhysicalApplicationPath + "/Filer/" + fileMoveFrom + "/" + fileName;
            string pathTo = Request.PhysicalApplicationPath + "/Filer/" + fileMoveTo + "/" + fileName;
            pathFrom.Replace("//", "/");
            pathTo.Replace("//", "/");


            ViewBag.Msg = ft.MoveFile(pathFrom, pathTo);
            return View();
        }

        public ActionResult CopyFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CopyFile(string fileName, string fileCopyFrom, string fileCopyTo)
        {

            string pathFrom = Request.PhysicalApplicationPath + "/Filer/" + fileCopyFrom + "/" + fileName;
            string pathTo = Request.PhysicalApplicationPath + "/Filer/" + fileCopyTo + "/" + fileName;
            pathFrom.Replace("//", "/");
            pathTo.Replace("//", "/");


            ViewBag.Msg = ft.CopyFile(pathFrom, pathTo);
            return View();
        }

        public ActionResult WriteToFile()
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/MyStyle.css";
            ViewBag.Style = ft.ReadFromFile(filePath);
            return View();
        }

        [HttpPost]
        public ActionResult WriteToFile(string text)
        {
            string filePath = Request.PhysicalApplicationPath + "/Filer/MyStyle.css";

            ft.WriteToFile(filePath, text);

            ViewBag.Style = text;

            return View();
        }

        public ActionResult GetFiles()
        {
            string path = Request.PhysicalApplicationPath + "Views/home/";

            return View(ft.GetAllFiles(path));
        }

        [ChildActionOnly]
        public ActionResult GetMenu()
        {
            string path = Request.PhysicalApplicationPath + "Views/home/";

            return PartialView("_menu", ft.GetAllFiles(path));
        }

        public ActionResult FlytMappe()
        {
            return View();
        }


        [HttpPost]
        public ActionResult FlytMappe(string mappeNavn)
        {
            string pathFrom = Request.PhysicalApplicationPath + "/Filer/" + mappeNavn;
            string pathTo = Request.PhysicalApplicationPath + "/Slut/" + mappeNavn;



            ViewBag.Msg = dt.MoveFolder(pathFrom, pathTo);
            return View();
        }

        public ActionResult Uploadfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Uploadfile(HttpPostedFileBase uploadFile)
        {
            string savePath = Request.PhysicalApplicationPath + "uploads/";

            string savedFileName = ft.uploadFile(uploadFile, savePath);

            ft.ReSizeImage(savedFileName, savePath + "300/", 300);

            ft.DeleteFile(savedFileName);

            ViewBag.msg = "filen" + uploadFile.FileName + "Er blevet gemt";

            return View();/*Redirect("Home/UploadFile");*/
        }


    }

}