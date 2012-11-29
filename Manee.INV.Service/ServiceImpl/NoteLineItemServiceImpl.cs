using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.ServiceInf;
using Manee.INV.DAL.DAOInf;

namespace Manee.INV.Service.ServiceImpl
{
    class NoteLineItemServiceImpl : INoteLineItemService
    {
        private INoteLineItemDAO nliDAO;
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
            NoteLineItem result = nliDAO.FindNoteLineItemById(id);
            return result;
        }







        //public void SetStatusToItem(int NLineItemId, int dnId, int destinationId)
        //{
        //    nliDAO.SetStatusToItem(NLineItemId, dnId, destinationId);
        //}

        /// <summary>
        /// เลือก NoteLineItem จากFilter ต่างๆ
        /// </summary>
        /// <param name="itemCriteria"></param>
        /// <returns></returns>
        public List<NoteLineItem> FindNoteLineItemByCriteria(NoteLineItem itemCriteria)
        {
            List<NoteLineItem> noteLineItemsAll = nliDAO.FindNoteLineItemByCriteria(itemCriteria);

            return noteLineItemsAll;
        }
    }
}
