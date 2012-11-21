using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service;
using System.Data.Entity;
using Manee.INV.DAL;
using Manee.INV.DAL.DaoInf;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.DeliveryNoteService
{

    public class DeliveryNoteService
    {
        private IDeliveryNoteDAO dao = (IDeliveryNoteDAO)DaoFactory.getDao("DELIVERY_NOTE");

        public void CreateDeliveryNote(DeliveryNote dn) {         
            dao.Create(dn);
        }

        public void DeleteDeliveryNote(int NoteId) {
            dao.Delete(NoteId);
        }

        public void UpdateDeliveryNote(DeliveryNote Note) {
            dao.Update(Note);
        }
    }
}
