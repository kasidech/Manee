using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
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
             List<Entity.DeliveryNote> resultList = new List<DeliveryNote>();



             resultList=context.DeliveryNotes.Where(
                 b => (!string.IsNullOrEmpty(b.Code) && b.Code.Contains(noteCriteria.Code))
                 ||(!string.IsNullOrEmpty(b.CarLicensePlate) && b.CarLicensePlate.Contains(noteCriteria.CarLicensePlate))
                 ||(!string.IsNullOrEmpty(b.CarType) && b.CarType.Contains(noteCriteria.CarType))
                 ||(b.DeliveryDate==noteCriteria.DeliveryDate)
                 ||(b.DestinationId==noteCriteria.DestinationId)
                 ||(b.OriginId==noteCriteria.OriginId)
                 ||(!string.IsNullOrEmpty(b.SenderCode) && b.SenderCode.Contains(noteCriteria.SenderCode))
                 ||(!string.IsNullOrEmpty(b.SenderName)&& b.SenderName.Contains(noteCriteria.SenderName))
                 ).ToList();
             return resultList;
        }




         int IDeliveryNoteDAO.CountDeliveryNote(string code)
         {
             int row = context.DeliveryNotes.Where(b => b.Code == code).Count();
             return row;
         }


         int IDeliveryNoteDAO.CountDeliveryNoteTableRow()
         {
             int row = context.DeliveryNotes.Count();
             return row;
         }
    }
}
