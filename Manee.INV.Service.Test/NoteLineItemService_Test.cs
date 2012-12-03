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

    public class PrepareNoteLineItemData 
    {
        INoteLineItemService noteLineItemService = (INoteLineItemService)DAOFactory.GetDao("NOTE_LINE_ITEM");
        
        public static NoteLineItem Sample()
        {
            ILocationDAO locationDAO = (ILocationDAO)DAOFactory.GetDao("LOCATION");
            ManeeDataContainer context = new ManeeDataContainer();

            NoteLineItem item = new NoteLineItem();
            item.Id=0;
            item.ItemCode = "LK-001";
            item.ItemDescription = "steel";
            
            item.Location = new Location();
            item.Location.Id = context.Locations.FirstOrDefault(m=>m.Id==2).Id;
            item.Quantity=1;
            item.Status = 1;
            item.Unit = "ton";
            return item;
        }
        /// <summary>
        /// ลบ Item จำลองอยู่ ใน Database ก่อนทำงาน
        /// </summary>
        public static void DeleteAllSampleData()
        {
            INoteLineItemDAO noteLineItemDAO =(INoteLineItemDAO)DAOFactory.GetDao("NOTE_LINE_ITEM");
            List<NoteLineItem> samplesInDB = noteLineItemDAO.FindNoteLineItemAll().Where(m => m.ItemCode == "LK-001").ToList();
            foreach(NoteLineItem sample in samplesInDB)
            {
                noteLineItemDAO.DeleteNoteLineItem(sample.Id);
            }
            
        }
    }

    [TestClass]
    public class NoteLineItemService_Test
    {
        INoteLineItemDAO noteLineItemDAO = (INoteLineItemDAO)DAOFactory.GetDao("NOTE_LINE_ITEM");
        INoteLineItemService noteLineItemService = (INoteLineItemService)ServiceFactory.GetService("NOTE_LINE_ITEM");
        IDeliveryNoteDAO deliveryNoteDAO = (IDeliveryNoteDAO)DAOFactory.GetDao("DELIVERY_NOTE");
        [TestMethod]
        public void CreateNoteLineItem_WithValidData()
        {
        }

        [TestMethod]
        public void DeleteNoteLineItem_WithValidData() 
        {
        }

        /// <summary>
        /// ทดสอบว่าใส่ข้อมูลลง Data  base ถูกต้อง
        /// </summary>
        [TestMethod]
        public void SetNoteLineItemToNote_CorrectItemAndNote()
        {
            PrepareNoteLineItemData.DeleteAllSampleData();
            PrepareDeliveryNoteData.DeleteAllSampleData();

            DeliveryNote note = new DeliveryNote();
            note = PrepareDeliveryNoteData.SampleData();
            deliveryNoteDAO.CreateDeliveryNote(note);

            NoteLineItem item = new NoteLineItem();
            item = PrepareNoteLineItemData.Sample();
            noteLineItemDAO.CreateNoteLineItem(item);


            // Method ที่ต้องการ Test---------------

            noteLineItemService.SetNoteLineItemToNote(item.Id, note.Id);

            //------------------------------------------

            ManeeDataContainer context = new ManeeDataContainer();
            NoteLineItem itemInDB = context.NoteLineItems.Where(m => m.ItemCode == item.ItemCode).FirstOrDefault();
            DeliveryNote noteInDB = context.DeliveryNotes.Where(m => m.Code == note.Code).FirstOrDefault();
            int expectedDeliveryNoteId = noteInDB.Id;



            int accualDeliveryNoteId = itemInDB.DeliveryNote.Id;

            //ต้องลบ NoteLinteItem ก่อนเพราะเรื่อง Foreign Key

            PrepareNoteLineItemData.DeleteAllSampleData();
            PrepareDeliveryNoteData.DeleteAllSampleData();
            

            Assert.AreEqual(expectedDeliveryNoteId, accualDeliveryNoteId, "Failed");

            

        }
    }
}
