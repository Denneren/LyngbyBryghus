using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbRepo.Models
{
    public class City
    {
        public int ID { get; set; }

        public int Zipcode { get; set; }

        public string CityName { get; set; }

        public string StreetName { get; set; }
    }
}
