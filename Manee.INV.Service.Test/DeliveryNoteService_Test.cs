using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceImpl;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL;
using Manee.INV.DAL.DAOImpl;
using Manee.INV.DAL.DAOInf;
using System.Data.Entity;


namespace Manee.INV.Service.Test
{
        public static class PrepareDeliveryNoteData 
        {
            


            public static void DeleteAllSampleData()
            {
                ManeeDataContainer context = new ManeeDataContainer();
                List<DeliveryNote> dns = context.DeliveryNotes.Where(b => b.Code == "DN001").ToList();
                IDeliveryNoteDAO dnDao = (IDeliveryNoteDAO)DAOFactory.GetDao("DELIVERY_NOTE");
                foreach(DeliveryNote dn in dns)
                {
                    dnDao.DeleteDeliveryNote(dn.Id);
                }
            }

            public static DeliveryNote SampleData()
            {

                ManeeDataContainer context = new ManeeDataContainer();
                DeliveryNote note = new DeliveryNote();

                note.Code = "DN001";
                note.DeliveryDate = DateTime.Now;
                note.Id = 0;
                note.Destination = new Location();
                note.Destination.Id = context.Locations.FirstOrDefault(b => b.Id == 2).Id;
                note.Origin =new Location() ;
                note.Origin.Id = context.Locations.FirstOrDefault(b=>b.Id==3).Id;
            

                //note.Destination = context.Locations.FirstOrDefault(b => b.Id == 2);
                //note.Origin = context.Locations.FirstOrDefault(b => b.Id == 3);

                note.SenderCode = "Sender1";
                note.SenderName = "SS";
                note.CarType = "Car";
                note.CarLicensePlate = "a-222";
                return note;
            }

        } 
        


    [TestClass]
    public class DeliveryNoteService_Test
    {
        
        protected static ILocationDAO lDao = (ILocationDAO)DAOFactory.GetDao("LOCATION");
        protected static IDeliveryNoteDAO dnDao = (IDeliveryNoteDAO)DAOFactory.GetDao("DELIVERY_NOTE");
        protected Location lc = lDao.FindLocationAll().Where(b => b.Id == 2).FirstOrDefault();
        ManeeDataContainer context = new ManeeDataContainer();



        [TestMethod]
        public void CreateDeliveryNote_WithValidData()
        {
            int expectedRow = 1;
            IDeliveryNoteDAO dao = new DeliveryNoteDAOImpl();
            
            PrepareDeliveryNoteData.DeleteAllSampleData();
            DeliveryNote note = PrepareDeliveryNoteData.SampleData();

            IDeliveryNoteService deliveryNotenService = new DeliveryNoteServiceImpl();
            deliveryNotenService.CreateDeliveryNote(note);



            
            int actualRow = dao.CountDeliveryNote("DN001");
            PrepareDeliveryNoteData.DeleteAllSampleData();
            

            Assert.AreEqual(expectedRow, actualRow, "Failed");
        }

        [TestMethod]
        public void DeleteDeliveryNote_WithValidData()
        {


            int expectedRow = 0;

            
            PrepareDeliveryNoteData.DeleteAllSampleData();
            DeliveryNote note = PrepareDeliveryNoteData.SampleData();

            IDeliveryNoteService deliveryNotenService = new DeliveryNoteServiceImpl();
            IDeliveryNoteDAO dao = new DeliveryNoteDAOImpl();

            dao.CreateDeliveryNote(note);

            int id = context.DeliveryNotes.Where(b => b.Code == "DN001").FirstOrDefault().Id;
            deliveryNotenService.DeleteDeliveryNote(id);

            int actualRow = dao.CountDeliveryNote("DN001");





            Assert.AreEqual(expectedRow, actualRow, "Failed");
        }

        }
    }

