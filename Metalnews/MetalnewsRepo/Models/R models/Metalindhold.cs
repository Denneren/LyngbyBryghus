using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalnewsRepo.Models
{
    public class Metalindhold
    {
        public int ID { get; set; }
        public string Overskrift { get; set; }
        public string Indhold { get; set; }
        public DateTime Dato { get; set; }

        public string Kunstner { get; set; }
    }
}
