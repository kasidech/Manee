using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOImpl
{
    public class NoteLineItemDAOImpl :INoteLineItemDAO 
    {
        private ManeeDataContainer context = new ManeeDataContainer();
        public void CreateNoteLineItem(Entity.NoteLineItem item)
        {
            
            //context.Locations.Attach(item.Location);
            //context.DeliveryNotes.Attach(item.DeliveryNote);
            //context.LocationTypes.Attach(item.Location.LocationType);
            context.Locations.Attach(item.Location);
            //context.DeliveryNotes.Attach(item.DeliveryNote);
            context.NoteLineItems.Add(item);
            
            
            context.SaveChanges();
        }

        public void DeleteNoteLineItem(int id)
        {
            var noteLineItem = context.NoteLineItems.FirstOrDefault(r => r.Id == id);
            context.NoteLineItems.Remove(noteLineItem);
            context.SaveChanges();
        }



        public void UpdateNoteLineItem(NoteLineItem item)
        {
            //NoteLineItem updateItem = context.NoteLineItems.FirstOrDefault(m => m.Id == item.Id);

            context.DeliveryNotes.Attach(item.DeliveryNote);
            //context.Locations.Attach(item.Location);
            //updateItem = item;
            //updateItem.DeliveryNote.Id = item.DeliveryNote.Id;
            //context.DeliveryNotes.Attach(updateItem.DeliveryNote);
            //context.Locations.Attach(updateItem.Location);
            
            context.SaveChanges();
        }






        public List<NoteLineItem> FindNoteLineItemAll()
        {
            List<NoteLineItem> result = context.NoteLineItems.ToList();
            return result;
        }



    }
}
