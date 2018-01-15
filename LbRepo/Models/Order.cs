using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbRepo.Models
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public int Payed { get; set; }

        public int CustomerID { get; set; }
    }
}
