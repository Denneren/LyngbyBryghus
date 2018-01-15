using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace opgave.Factories
{
    public class FacSelect
    {

        public string CreateSelectOptions()
        {
            string output = "";

            string[] arrOptions = { "værdi 1", "værdi 2", "værdi 3", "værdi 4", "værdi 5" };

            foreach (string item in arrOptions)

            {
                output += "<option value=\"" + item + "\">" + item + "</ option>";
            }
            return output;
        }
        public string CreateSelectResponse(string input) { return "Du har valgt " + input + " i din Select"; }
    }
}