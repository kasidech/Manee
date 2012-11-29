using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceImpl;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOImpl;
using Manee.INV.DAL.DAOInf;
using System.Data.Entity;

namespace UnitTestProject1
{
    [TestClass]
    public class DeliveryNoteServiceTest
    {
        [TestMethod]
        public void Create_WithValidDeliveryNote()
        {
            int expectedRow = 1;

            DeliveryNote note = new DeliveryNote();
            note.Code = "DN001";
            note.DeliveryDate = DateTime.Now;
            note.Destination.Id = 1;
            note.Origin.Id = 2;
            note.SenderCode = "Sender1";
            note.SenderName = "SS";
            note.CarType = "Car";
            note.CarLicensePlate = "a-222";

            IDeliveryNoteService dnService = new DeliveryNoteServiceImpl();
            dnService.CreateDeliveryNote(note);



            IDeliveryNoteDAO dao = new DeliveryNoteDAOImpl();
            int actualRow = dao.CountDeliveryNote("DN001");
            List<DeliveryNote> ldn = dao.FindByCriteria(note);
            int id = ldn.LastOrDefault().Id;


            dao.Delete(id);
            Assert.AreEqual(expectedRow, actualRow,  "Failed");
        }

        [TestMethod]
        public void Delete_WithValidDeliveryNote() 
        {
            int expectedRow = 0;

            DeliveryNote note = new DeliveryNote();
            note.Code = "DN002";
            note.DeliveryDate = DateTime.Now;
            note.Destination.Id = 1;
            note.Origin.Id = 2;
            note.SenderCode = "Sender1";
            note.SenderName = "SS";
            note.CarType = "Car";
            note.CarLicensePlate = "a-222";

            IDeliveryNoteService dnService = new DeliveryNoteServiceImpl();
            IDeliveryNoteDAO dao = new DeliveryNoteDAOImpl();

            dao.Create(note);
            List<DeliveryNote> ldn = dao.FindByCriteria(note);
            int id = ldn.LastOrDefault().Id;
            dnService.DeleteDeliveryNote(id);

            int actualRow = dao.CountDeliveryNote("DN002");
            


           

            Assert.AreEqual(expectedRow, actualRow, "Failed");


        }


    }
}
