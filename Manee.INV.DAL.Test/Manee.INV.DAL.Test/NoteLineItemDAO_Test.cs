using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manee.INV.DAL.Entity;
using Manee.INV.DAL.DAOInf;
namespace Manee.INV.DAL.Test
{
    [TestClass]
    public class NoteLineItemDAO_Test
    {
        INoteLineItemDAO dao = (INoteLineItemDAO)DAOFactory.getDao("NOTE_LINE_ITEM");
        ManeeDataContainer context = new ManeeDataContainer();

        public NoteLineItem Sample()
        {
            NoteLineItem sampleItem = new NoteLineItem();

           sampleItem.ItemCode = "12345s";
           sampleItem.ItemDescription = "Table";
           sampleItem.Status = 1;
           sampleItem.Quantity = 1;
           sampleItem.Unit = "unit";
           sampleItem.Location = context.Locations.Where(b=>b.Id==2);
           return sampleItem;
        
        }
        
        
        [TestMethod]
        public void CreateNoteLineItem_validData()
        {

            int expectedRow = context.NoteLineItems.Count()+1;

            NoteLineItem sampleItem = Sample();

            dao.CreateNoteLineItem(sampleItem);

            int resultRow = context.NoteLineItems.Count();
            int itemId = context.NoteLineItems.LastOrDefault().Id;
            dao.DeleteNoteLineItem(itemId);


            Assert.AreNotEqual(expectedRow, resultRow, "Failed");


        }
        [TestMethod]
        public void DeleteNoteLineItem()
        {
        }
         [TestMethod]
        public void FindNoteLineItemAll()
        {
        }
    
    }
}
