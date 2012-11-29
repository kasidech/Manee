using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceInf
{
    public interface INoteLineItemService
    {
        void CreateNoteLineItem(NoteLineItem item);
        void DeleteNoteLineitem(int id);
        NoteLineItem FindNoteLineItemById(int id);
        //void SetStatusToItem(int NLineItemId, int dnId, int destinationId);
        List<NoteLineItem> FindNoteLineItemByCriteria(NoteLineItem itemCriteria);
      
    }
}
