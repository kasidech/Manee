using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.DAOImpl;
using Manee.INV.DAL;
using System.Text;
using Manee.INV.DAL.Entity;
using System.Data;
using System.Linq;



namespace Manee.INV.DAL.Test
{
    [TestClass]
    public class CarDAO_Test
    {
        ICarDAO dao = (ICarDAO)DAOFactory.getDao("CAR");
        ManeeDataContainer context = new ManeeDataContainer();
        [TestMethod]
        public void FindCarsAll_Count()
        {
            List<Car> cars = dao.FindCarAll();
            List<Car> carsDb = context.Cars.ToList();

            Assert.AreNotEqual(cars, carsDb, "Failed");
        }
    }
}
