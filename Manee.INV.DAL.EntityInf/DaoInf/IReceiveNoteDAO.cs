using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DaoInf
{
    public interface IReceiveNoteDAO
    {
        void Create(ReceiveNote note,int dnId);
        void Delete(int noteId);
        void Update(ReceiveNote note);
        ReceiveNote FindById(int id);
        List<ReceiveNote> FindByCriteria(ReceiveNote noteCriteria);
    }
}
