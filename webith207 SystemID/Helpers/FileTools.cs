using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace webith207_SystemID.Helpers
{
    public class FileTools
    {
        public string CreateFile(string filePath)
        {

            StreamWriter sw = File.CreateText(filePath);
            sw.Close();
            return "Filen er oprettet";
        }

        public string DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return "Filen er slettet";
            }

            else
            {
                throw new Exception("The file marked does not exsist");
                //return "Filen: <b>" + filePath + "</b> findes ikke";
            }
        }

        public string MoveFile(string pathFrom, string pathTo)
        {
            if (File.Exists(pathFrom))
            {
                File.Move(pathFrom, pathTo);
                return "Filen er nu flyttet!";
            }
            else
            {
                return "Filen blev ikke fundet";
            }

        }
        public string CopyFile(string pathFrom, string pathTo)
        {
            if (File.Exists(pathFrom))
            {
                File.Copy(pathFrom, pathTo);
                return "Filen er nu kopieret";
            }
            else
            {
                return "Filen blev ikke fundet!";
            }
        }

        public void WriteToFile(string path, string text)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.Write(text + "\n");
            sw.WriteLine("/*Opdateret:" + DateTime.Now + "*/\n");
            sw.Close();
        }

        public string ReadFromFile(string path)
        {
            StreamReader sr = File.OpenText(path);
            string input = sr.ReadToEnd();
            sr.Close();

            return input;
        }

        public FileInfo[] GetAllFiles(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo myDirectory = new DirectoryInfo(path);
                FileInfo[] files = myDirectory.GetFiles();

                return files;
            }
            else
            {
                throw new Exception("The folder" + path + "is missing");
            }
        }


        public void LogError(string exMessage)
        {
            string logFolder =
                HttpContext.Current.Request.PhysicalApplicationPath + "Logs/";

            if (Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);

            }
            string logName = DateTime.Today.ToString("yyyyMMdd") + ".txt";
            string pathName = logFolder + "/" + logName;

            string errorMessage = DateTime.Today.ToShortDateString() + " : " + DateTime.Now.ToLongTimeString() + "==>" + exMessage;

            if (!File.Exists(pathName))
            {
                using (StreamWriter sw = File.CreateText(pathName))
                {
                    sw.WriteLine(errorMessage);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(pathName, true))
                {
                    sw.WriteLine(errorMessage);
                    sw.Close();
                }
            }



        }
        public string uploadFile(HttpPostedFileBase uploadedFile, string outputPath)
        {
            string fileName = Path.GetFileName(uploadedFile.FileName);
            fileName.Replace(" ", "_");
            fileName.Replace("ø", "oe");
            fileName.Replace("æ", "ae");
            fileName.Replace("å", "aa");

            uploadedFile.SaveAs(outputPath + fileName);

            return outputPath + fileName;
        }

        public string ReSizeImage(string imagePath, string imagePathTo, int newwidth)
        {
            System.Drawing.Image bm = System.Drawing.Image.FromFile(imagePath);

            int newHeight = (bm.Height * newwidth) / bm.Width;

            Bitmap resized = new Bitmap(newwidth, newHeight);

            Graphics g = Graphics.FromImage(resized);

            g.DrawImage(bm, new Rectangle(0, 0, resized.Width, resized.Height), 0, 0, bm.Width, bm.Height, GraphicsUnit.Pixel);

            g.Dispose();
            bm.Dispose();
            string fileName = Path.GetFileName(imagePath);

            if (Directory.Exists(imagePathTo) == false)
            {
                Directory.CreateDirectory(imagePathTo);
            }

            resized.Save(imagePathTo + fileName, ImageFormat.Jpeg);

            return imagePathTo;
        }
    }
}
