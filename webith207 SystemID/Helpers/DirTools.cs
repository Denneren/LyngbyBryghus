using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace webith207_SystemID.Helpers
{
    public class DirTools
    {
        public void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
        }

        public void DeleteFolder(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }
        public string MoveFolder(string pathFrom, string pathTo)
        {
            if (Directory.Exists(pathFrom))
            {

                // Physical/Filer/Hest
                // Physical/Slut/Hest

                Directory.Move(pathFrom, pathTo);
                return "Mappen er flyttet";
            }
            else
            {
                throw new Exception("Mapen findes ikke");
            }
        }
    }
}