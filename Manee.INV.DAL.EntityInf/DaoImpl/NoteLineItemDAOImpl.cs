using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DaoImpl
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






    }
}
