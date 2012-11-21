using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DaoInf;
using Manee.INV.DAL.Entity;
using System.Data.Entity;



namespace Manee.INV.DAL.DaoImpl
{
    public class DeliveryNoteDAOImpl : IDeliveryNoteDAO
    {
        private ManeeDataContainer context = new ManeeDataContainer();

        void IDeliveryNoteDAO.Create(Entity.DeliveryNote note)
        {
            context.DeliveryNotes.Add(note);
            context.SaveChanges();
        }

        void IDeliveryNoteDAO.Delete(int noteId)
        {
            DeliveryNote deletingNote = context.DeliveryNotes.FirstOrDefault(p=>p.Id == noteId);
            context.DeliveryNotes.Remove(deletingNote);
            context.SaveChanges();
            
        }

        void IDeliveryNoteDAO.Update(Entity.DeliveryNote note)
        {
            DeliveryNote updateNote = context.DeliveryNotes.FirstOrDefault(p => p.Id == note.Id);
            updateNote.Code = note.Code;
            updateNote.DeliveryDate = note.DeliveryDate;
            updateNote.DestinationId = note.DestinationId;
            updateNote.DocumentDate = note.DocumentDate;
            updateNote.CarLicensePlate = note.CarLicensePlate;
            updateNote.CarType = note.CarType;

            context.SaveChanges();
           
        }

         Entity.DeliveryNote IDeliveryNoteDAO.FindById(int id)
        {
            DeliveryNote allDeliveryNote = context.DeliveryNotes.FirstOrDefault(b=>b.Id == id);
            return allDeliveryNote;
           
        }

         List<Entity.DeliveryNote> IDeliveryNoteDAO.FindByCriteria(Entity.DeliveryNote noteCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
