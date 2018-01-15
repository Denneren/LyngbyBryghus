using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbRepo.Models
{
    public class CustomerLogin
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int CustomerDataID { get; set; }
    }
}
