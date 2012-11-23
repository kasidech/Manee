using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceInf
{
    public interface IReceiveNoteService
    {
        void CreateReceiveNote(ReceiveNote note);
        void DeleteReceiveNote(int id);
        void UpdateReceiveNote(ReceiveNote note);
        ReceiveNote FindReceiveNoteById(int id);
    }
}
