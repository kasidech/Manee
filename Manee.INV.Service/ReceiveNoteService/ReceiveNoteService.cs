using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Manee.INV.DAL;
using Manee.INV.DAL.DaoInf;
using Manee.INV.DAL.Entity;

namespace Manee.INV.ReceiveNoteService
{
    
    class ReceiveNoteService 
    {
        private IReceiveNoteDAO dao = (IReceiveNoteDAO)DaoFactory.getDao("RECEIVE_NOTE");

        public void CreateDeliveryNote(ReceiveNote rc, int dnId)
        {

            dao.Create(rc,dnId);


        }

        public void DeleteDeliveryNote(int NoteId)
        {
            dao.Delete(NoteId);
        }

        public void UpdateDeliveryNote(ReceiveNote Note)
        {
            dao.Update(Note);
        }
    }
}
