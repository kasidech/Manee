using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace DAL.Services
{
    public class ReceiptNoteService:BaseService
    {
        public ReceitpNote GetReceiptNoteById(decimal? id)
        {
            return db.ReceitpNotes.FirstOrDefault(r => r.Id == id);
        }

        public void CreateReceiptNote(ReceitpNote rn)
        {
            db.ReceitpNotes.AddObject(rn);
            db.SaveChanges();
        }
    }
}
