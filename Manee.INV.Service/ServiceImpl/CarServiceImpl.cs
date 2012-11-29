﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceImpl
{
    class CarServiceImpl : ICarService
    {
        ICarDAO dao = (ICarDAO)DAOFactory.getDao("CAR");
        public List<DAL.Entity.Car> FindCarAll()
        {
            List<Car> cars = dao.FindCarAll();
            return cars;
        }
    }
}