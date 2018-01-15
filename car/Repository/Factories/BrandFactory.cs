using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Duser;

namespace Repository.Factories
{
    public class BrandFactory : AutoFac<Brand>
    {
        public List<Brand> GetAll()
        {
            string SQL = "SELECT ID, BrandName FROM Brand";
            return ExecuteSQL<Brand>(SQL);
        }
        public void AddNew(Brand input)
        {
            string SQL = "INSERT INTO Brand(BrandName)VALUES ('" + input.BrandName + "')";

            ExecuteSQL(SQL);
        }
        public void Delete(int ID)
        {
            string SQL = "DELETE FROM Brand WHERE ID =" + ID;
            ExecuteSQL(SQL);
                 }
    }
}
