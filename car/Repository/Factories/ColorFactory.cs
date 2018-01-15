using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duser;
using Repository.Models;

namespace Repository.Factories
{
    public class ColorFactory : AutoFac<Color>
    {
        public List<Color> GetAll()
        {
            string SQL = "SELECT ID, ColorName FROM Color";

            return ExecuteSQL<Color>(SQL);
        }

        public Color GetByID(int ID)
        {
            string SQL = "SELECT ID,ColorName FROM Color WERE ID=" + ID;
            return ExecuteSQL<Color>(SQL)[0];
        }

        public void AddNew(Color input)
        {
            string SQL = "INSERT INTO COLOR(ColorName) VALUES('" + input.ColorName + "')";
            ExecuteSQL(SQL);
        }
        public void Delete(int ID)
        {
            string SQL = "DELETE FROM Color WHERE ID =" + ID;
            ExecuteSQL(SQL);
        }

        public void Update(Color input)
        {
            String SQL = "UPDATE Color SET ColorName ='" + input.ColorName + "'WHERE ID=" + input.ID;
            ExecuteSQL(SQL);
        }
    }
}
