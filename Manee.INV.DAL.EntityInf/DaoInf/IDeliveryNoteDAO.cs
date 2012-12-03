using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOInf
{
    public interface IDeliveryNoteDAO
    {
        void CreateDeliveryNote(DeliveryNote note);
        void DeleteDeliveryNote(int noteId);
        void UpdateDeliveryNote(DeliveryNote note);
        DeliveryNote FindById(int id);
        List<DeliveryNote> FindByCriteria(DeliveryNote noteCriteria);
        int CountDeliveryNote(string code);
        int CountDeliveryNoteTableRow();
        List<DeliveryNote> FindDeliveryNoteAll();
        
    }    
}
