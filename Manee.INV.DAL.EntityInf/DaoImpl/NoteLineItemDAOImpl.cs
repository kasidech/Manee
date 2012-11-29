using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOImpl
{
    public class NoteLineItemDAOImpl :INoteLineItemDAO 
    {
        private ManeeDataContainer context = new ManeeDataContainer();
        public void CreateNoteLineItem(Entity.NoteLineItem item)
        {
            context.NoteLineItems.Add(item);
            context.SaveChanges();
        }

        public void DeleteNoteLineItem(int id)
        {
            var noteLineItem = context.NoteLineItems.FirstOrDefault(r => r.Id == id);
            context.NoteLineItems.Remove(noteLineItem);
            context.SaveChanges();
        }


        NoteLineItem INoteLineItemDAO.FindNoteLineItemById(int id)
        {
            throw new NotImplementedException();
        }








        public List<NoteLineItem> FindNoteLineItemByCriteria(NoteLineItem itemCriteria)
        {
            List<NoteLineItem> resultList = new List<NoteLineItem>();

            resultList = context.NoteLineItems.Where(b => (!string.IsNullOrEmpty(b.ItemCode) && b.ItemCode.Contains(itemCriteria.ItemCode))
                || (!string.IsNullOrEmpty(b.ItemDescription) && b.ItemDescription.Contains(itemCriteria.ItemDescription))
                || (b.Location.Id != null && b.Location.Id == itemCriteria.Location.Id)
                || (b.Quantity != null && b.Quantity == itemCriteria.Quantity)
                || (b.Status != null && b.Status == itemCriteria.Status)).ToList();

            return resultList;
        }
        
    }
}
