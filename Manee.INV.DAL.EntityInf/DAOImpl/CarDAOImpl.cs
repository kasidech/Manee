using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOImpl
{
    public class CarDAOImpl : ICarDAO
    {
        ManeeDataContainer context = new ManeeDataContainer();
        public List<Entity.Car> FindCarAll()
        {
            List<Car> cars = context.Cars.ToList();
            return cars;
        }
    }
}
