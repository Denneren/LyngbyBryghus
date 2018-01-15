using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duser;
using Repository.Models;

namespace Repository.Factories
{
    public class HpFactory : AutoFac<Hp>
    {
        public List<Hp> GetAll()
        {
            string SQL = "SELECT ID, HpName FROM Hp";

            return ExecuteSQL<Hp>(SQL);
        }
    }
}
