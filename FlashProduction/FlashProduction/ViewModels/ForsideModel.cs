using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlashRepo.Models;

namespace FlashProduction.ViewModels
{
    public class ForsideModel
    {
        public List<Egotable> egoTables { get; set; }

        public List<Egotable2> egoTables2 { get; set; }

        public List<Programmer> proTabels { get; set; }
    }
}