using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using Manee.INV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manee.INV.DAL.Models;




namespace Manee.INV.DAL.Services
{
    public class DeliveryNoteRepository
    {
         public void Create()
         {
             DeliveryNote dn = new DeliveryNote();

             dn.OriginId = 1;
             dn.DestinationId = 1;
             dn.Cartype = null;
             dn.DriverName = null;
             dn.CarLicensePlate = null;
             dn.SenderCode = null;
             dn.SenderName = null;


             TOCPPContainer1 ct = new TOCPPContainer1();

             ct.DeliveryNotes.AddObject(dn);
             ct.SaveChanges();

         }
    }

}