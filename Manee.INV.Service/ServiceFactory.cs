﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.Service.ServiceImpl;

namespace Manee.INV.Service
{
    public class ServiceFactory
    {
        public static Object GetService(String serviceName) 
        {

            if (serviceName.Equals("DELIVERY_NOTE")) 
            {
                IDeliveryNoteService service = new DeliveryNoteServiceImpl();
                return service;
            }
            else if(serviceName.Equals("RECEIVE_NOTE"))
            {
                IReceiveNoteService service = new ReceiveNoteImpl();
                return service;
            }
            else
            {
                return null;
            }
        }
    }
}
