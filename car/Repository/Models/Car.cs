using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string CarModel { get; set; }
        public long KM { get; set; }
        public int BrandID { get; set; }
        public int HpID { get; set; }
        public int ColorID { get; set; }

    }
}
