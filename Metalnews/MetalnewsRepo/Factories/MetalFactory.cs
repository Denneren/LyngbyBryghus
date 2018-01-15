using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalnewsRepo.Models;
using Duser;

namespace MetalnewsRepo.Factories
{
    public class MetalFactory : AutoFac<Metal>
    {
        public List<Metal> GetAll()
        {
            string SQL = "SELECT ID, Overskrift, Indhold, Dato, KunstnerID FROM Metal";

            return ExecuteSQL<Metal>(SQL);
        }
        public List<Metalindhold> GetAllJoin()
        {
            string SQL = "SELECT Metal.ID, Overskrift, Indhold, Dato, Kunstner FROM Metal  INNER JOIN Kunstnere ON KunstnerID = Kunstnere.ID";

            return ExecuteSQL<Metalindhold>(SQL);
        }

        public Metalindhold GetDetails(int ID)
        {
            string SQL = "SELECT Metal.ID,Overskrift, Indhold, Dato, Kunstner FROM Metal INNER JOIN Kunstnere ON KunstnerID = Kunstnere.ID WHERE Metal.ID = " + ID;


            return ExecuteSQL<Metalindhold>(SQL)[0]; //[0] fortæller at det er den enkelte af listen vi skal sende tilbage

        }

        public void AddNew(Metal input)
        {
            string SQL = "INSERT INTO Metal (Overskrift, Indhold, Dato, KunstnerID) "
                      + "VALUES('" + input.Overskrift
                        + "', '"
                        + input.Indhold
                        + "','"
                        + input.Dato.ToString("yyyy-MM-dd")
                        + "',"
                        + input.KunstnerID
                        + ")";


            ExecuteSQL(SQL);
        }
        public void Delete(int ID)
        {
            string SQL = "DELETE FROM Metal WHERE ID =" + ID;
            ExecuteSQL(SQL);
        }
    }
}
