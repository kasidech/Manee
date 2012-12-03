using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using Manee.INV.DAL;
using Manee.INV.DAL.DAOImpl;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.Entity;
using System.Data;
using System.Linq;

namespace Manee.INV.DAL.Test
{
    [TestClass]
    public class LocationDAO_Test
    {


        ILocationDAO dao = (ILocationDAO)DAOFactory.GetDao("LOCATION");




        ManeeDataContainer context = new ManeeDataContainer();
       

        //public void CreateLocation()
        //{

        //    Location createlocation = new Location();
        //    createlocation.Code = "l001";
        //    createlocation.Name = "location";
        //    createlocation.Address = "บางปู";
        //    createlocation.ProjectManagerId = 1;
        //    createlocation.LocationType.Id = 2;
        //    dao.CreateLocation(createlocation);

        //    int id = context.Locations.LastOrDefault().Id;
        //    Location locationDB = context.Locations.FirstOrDefault(l => l.Id == createlocation.Id);

        //    dao.DeleteLocation(id);
        //    Assert.AreNotEqual(locationDB, "Failed");

        //}


        [TestMethod]

        public void FindLocationAll()
        {
            List<Location> location = dao.FindLocationAll();
            List<Location> locationDB = context.Locations.ToList();

            Assert.AreNotEqual(location, locationDB, "Failed");
        }

        //public void A_MapsTo_B()
        //{
        //    var a = new A();
        //    a.Name = "name";

        //    var b = new B();
        //    Mapper.MapNames(a, b);

        //    Assert.AreEqual(a.name, b.name);
        //}

    }
}
