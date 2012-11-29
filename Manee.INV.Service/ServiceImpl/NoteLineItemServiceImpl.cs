using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
namespace Manee.INV.Service.ServiceImpl
{
    class NoteLineItemServiceImpl : INoteLineItemService
    {
        private INoteLineItemDAO nliDAO = (INoteLineItemDAO)DAOFactory.getDao("NOTE_LINE_ITEM");
        public void CreateNoteLineItem(NoteLineItem item)
        {
            nliDAO.CreateNoteLineItem(item);
        }

        public void DeleteNoteLineitem(int id)
        {
            
            nliDAO.DeleteNoteLineItem(id);
        }

        public NoteLineItem FindNoteLineItemById(int id)
        {
            NoteLineItem result = nliDAO.FindNoteLineItemAll().Where(b=>b.Id==id).FirstOrDefault();
            return result;
        }



        public List<NoteLineItem> FindNoteLineItemByLocation(int location_Id)
        {
            List<NoteLineItem> result = nliDAO.FindNoteLineItemAll().Where(b=>b.Location.Id==location_Id).ToList();
            return result;
        }
    }
}
