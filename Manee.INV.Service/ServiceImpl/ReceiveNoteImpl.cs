using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceInf;
using Manee.INV.Service;
using Manee.INV.DAL.DaoInf;
using Manee.INV.DAL;


namespace Manee.INV.Service.ServiceImpl
{
    class ReceiveNoteImpl : IReceiveNoteService
    {
        private IReceiveNoteDAO dao = (IReceiveNoteDAO)DAOFactory.getDao("RECEIVE_NOTE");

        public void CreateReceiveNote(ReceiveNote note)
        {

            dao.Create(note);


        }

        public void DeleteReceiveNote(int NoteId)
        {
            dao.Delete(NoteId);
        }

        public void UpdateReceiveNote(ReceiveNote Note)
        {
            dao.Update(Note);
        }
        public ReceiveNote FindReceiveNoteById(int id)
        {
            ReceiveNote result = dao.FindById(id);
            return result;

        }
    }
}
