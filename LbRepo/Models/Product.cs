using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbRepo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContentText { get; set; }

        public string Image { get; set; }

        public int CategoryID { get; set; }
        public decimal Price { get; set; }
    }
}
