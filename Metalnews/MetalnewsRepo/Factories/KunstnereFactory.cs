using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalnewsRepo.Models;
using Duser;

namespace MetalnewsRepo.Factories
{
    public class KunstnereFactory : AutoFac<kunstnere>
    {
        public List<kunstnere> GetAll()
        {
            string SQL = "SELECT ID, kunstner FROM Kunstnere";

            return ExecuteSQL<kunstnere>(SQL);
        }

        public void AddNew(kunstnere input)
        {
            string SQL = "INSERT INTO Kunstnere (Kunstner) VALUES('" + input.Kunstner + "')";

            ExecuteSQL(SQL);
        }

        public void Delete(int ID)
        {
            string SQL = "DELETE FROM Kunstnere WHERE ID =" + ID;
            ExecuteSQL(SQL);
        }
    }
}

