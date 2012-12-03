using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
namespace Manee.INV.Service.ServiceImpl
{
    public class NoteLineItemServiceImpl : INoteLineItemService
    {
        private INoteLineItemDAO noteLineItemDAO = (INoteLineItemDAO)DAOFactory.GetDao("NOTE_LINE_ITEM");
        public void CreateNoteLineItem(NoteLineItem item)
        {
            noteLineItemDAO.CreateNoteLineItem(item);
        }

        public void DeleteNoteLineitem(int id)
        {
            
            noteLineItemDAO.DeleteNoteLineItem(id);
        }

        public NoteLineItem FindNoteLineItemById(int id)
        {
            NoteLineItem result = noteLineItemDAO.FindNoteLineItemAll().Where(b=>b.Id==id).FirstOrDefault();
            return result;
        }



        public List<NoteLineItem> FindNoteLineItemByLocation(int location_Id)
        {
            List<NoteLineItem> result = noteLineItemDAO.FindNoteLineItemAll().Where(b=>b.Location.Id==location_Id).ToList();
            return result;
        }

        /// <summary>
        /// ตั้งค่า DeliveryNote Id ให้กับ Item เพื่อให้ Item ผูกกับ DeliveryNote 
        /// </summary>
        /// <param name="item_Id"></param>
        /// <param name="note_Id"></param>
        /// <returns></returns>
        public void SetNoteLineItemToNote(int item_Id, int note_Id)
        {
            NoteLineItem item = noteLineItemDAO.FindNoteLineItemAll().Where(m=>m.Id==item_Id).FirstOrDefault();
            IDeliveryNoteDAO deliveryNoteDAO = (IDeliveryNoteDAO)DAOFactory.GetDao("DELIVERY_NOTE");
            DeliveryNote note = deliveryNoteDAO.FindById(note_Id);

            item.DeliveryNote = new DeliveryNote();
            item.DeliveryNote.Id = note.Id;

            //note.NoteLineItems = item.;
            //item.DeliveryNote.Id = note.Id;
            noteLineItemDAO.UpdateNoteLineItem(item);
            

            
        }
    }
}
