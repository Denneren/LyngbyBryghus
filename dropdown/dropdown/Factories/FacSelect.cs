using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dropdown.Factories
{
    public class FacSelect
    {
        public string CreateSelectOptions()
        {
            string output = "";

            string[] arrOptions = { "værdi1", "værdi2", "værdi3" };

            foreach (string item in arrOptions)
            {
                output += "option value=\"" + item + "\">" + item + "</option>";
            }
            return output;
        }
    }
}