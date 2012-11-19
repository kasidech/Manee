using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL.Services
{
    public class DeliveryNoteService:BaseService
    {
        public DeliveryNotes GetDeliveryNoteById(decimal? id)
        {
            return db.DeliveryNotes.FirstOrDefault(d => d.Id == id);
        }

        public void CreateDeliveryNote(DeliveryNotes dn)
        {
            db.DeliveryNotes.AddObject(dn);
            db.SaveChanges();
        }

        public void DeleteDeliveryNote(int id)
        {
            var deletingDn=new DeliveryNotes();
            db.DeliveryNotes.DeleteObject(deletingDn);
        }

        
    }
}
