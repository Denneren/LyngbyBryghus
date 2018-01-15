using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace TinyCMS.Helpers
{
    public class FileTools
    {
        public string Imageupload(HttpPostedFileBase image, string outputPath)
        {
            string fileName = Path.GetFileName(image.FileName);

            string[] allowedTypes = { "jpg", "jpeg", "png" };

            string extension = Path.GetExtension(fileName).Substring(1).ToLower();

            if (allowedTypes.Contains(extension))
            {
                string newName = DateTime.Now.ToString("yyyyMMddhhmmss") + "." + extension;


                image.SaveAs(outputPath + newName);

                return newName;
            }
            else
            {
                return null;
            }
        }
    }
}