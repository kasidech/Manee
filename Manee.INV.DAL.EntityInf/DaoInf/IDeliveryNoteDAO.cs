using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DaoInf
{
    public interface IDeliveryNoteDAO
    {
         void Create(DeliveryNote note);
         void Delete(int noteId);
         void Update(DeliveryNote note);
         DeliveryNote FindById(int id);
         List<DeliveryNote> FindByCriteria(DeliveryNote noteCriteria);
    }    
}
