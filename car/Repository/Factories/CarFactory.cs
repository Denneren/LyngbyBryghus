using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Duser;

namespace Repository.Factories
{
    public class CarFactory : AutoFac<Car>
    {

        public List<Car> GetAll()
        {
            string SQL = "SELECT ID, CarModel, KM, ColorID, BrandID, HpID FROM Car";
            return ExecuteSQL<Car>(SQL);
        }

        public Car GetByID(int ID)
        {
            string SQL = "SELECT ID,CarModel,KM,BrandID,ColorID,HpID FROM Car WHERE ID=" + ID;

            return ExecuteSQL<Car>(SQL)[0];
        }

        public List<CarBrandColorHp> GetAllJoin()
        {
            string SQL =
                "SELECT Car.ID, BrandName,ColorName,HpName,CarModel,KM FROM Car Inner join Brand ON Brand.ID = Car.BrandID Inner Join Color ON Color.ID = Car.ColorID Inner Join Hp ON Hp.ID = Car.HpID "; //Indhold
            return ExecuteSQL<CarBrandColorHp>(SQL);
        }


        public void Update(Car input)
        {
            string SQL = "UPDATE Car SET"

            + "CarModel='" + input.CarModel + "',"
            + "KM =" + input.KM","
             + "BranndID =" + input.BrandID + ","
             + "ColorID =" + input.ColorID + ","
             + "HpID =" + input.HpID + " "
             + "WHERE ID =" + input.ID;
        }

    }
}
