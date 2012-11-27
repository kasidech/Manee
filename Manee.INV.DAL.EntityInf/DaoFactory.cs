﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.DaoImpl;

namespace Manee.INV.DAL
{
    public class DAOFactory
    {
        public static Object getDao(String daoName)
        {
            if (daoName.Equals("DELIVERY_NOTE"))
            {
                IDeliveryNoteDAO dao = new DeliveryNoteDAOImpl();
                return dao;
            }
            else if (daoName.Equals("RECEIVE_NOTE"))
            {
                var dao = new ReceiveNoteDAOImpl();
                return dao;
            }
            else
            {
                return null;
            }
        }
    }
}
