using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.Test
{
    [TestClass]
    public class CarService_Test
    {
        ICarService service = (ICarService)ServiceFactory.GetService("CAR");
        ICarDAO dao = (ICarDAO)DAOFactory.getDao("CAR");
        [TestMethod]
        public void FindCarAll_Count()
        {
            List<Car> cars = dao.FindCarAll();
            List<Car> carsFromService = service.FindCarAll();

            Assert.AreNotEqual(cars, carsFromService, "Failed");
        }
    }
}
