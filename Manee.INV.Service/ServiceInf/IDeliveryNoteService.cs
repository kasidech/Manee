using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceInf
{
    public interface IDeliveryNoteService
    {
        void CreateDeliveryNote(DeliveryNote note);
        void DeleteDeliveryNote(int noteId);
        void UpdateDeliveryNote(DeliveryNote note);
        DeliveryNote FindDeliveryNoteById(int id);
        List<DeliveryNote> FindDeliveryNoteByCriteria(DeliveryNote note);
        
    }
}
