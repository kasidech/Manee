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

        /// <summary>
        /// เรียก NoteLineItem ที่อยู่ภายใน Location นั้นๆ
        /// </summary>
        /// <param name="location_Id"></param>
        /// <returns></returns>
        List<NoteLineItem> FindNoteLineItemByLocation(int location_Id);
      
    }
}
