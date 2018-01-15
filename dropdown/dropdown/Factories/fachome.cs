using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dropdown.Factories
{
    public class facHome
    {
        public string InputFornavnEfternavn(string fornavn, string efternavn)
        {
            return "Dit navn er" + fornavn + "" + efternavn;
        }
    }
}