using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace car
{
    public class CarOptions
    {
        public List<Brand> Brands { get; set; }
        public List<Color> Colors { get; set; }
        public List<Hp> Hps { get; set; }
    }
}