using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalnewsRepo.Models
{
    public class Metal
    {
        public int ID { get; set; }
        public string Overskrift { get; set; }
        public string Indhold { get; set; }
        public DateTime Dato { get; set; }
        public int KunstnerID { get; set; }
    }
}
