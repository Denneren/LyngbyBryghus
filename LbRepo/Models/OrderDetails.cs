﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbRepo.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int Amount { get; set; }

        public decimal Total { get; set; }
    }
}
