using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Manee.INV.DB.Models;

namespace Manee.INV.DB.Controllers
{
    public class TestEF
    {
        public void CreateNoteLineItem(NoteLineItem item)
        {
            using (TOCPPContainer ctx = new TOCPPContainer())
            {
                ctx.NoteLineItems.ApplyCurrentValues(item);
                ctx.SaveChanges();
            }

        }

        public static void Main()
        {
            NoteLineItem item = new NoteLineItem();
            item.Id = 123;
            TestEF t = new TestEF();
            t.CreateNoteLineItem(item);

            Console.WriteLine("Helle");

        }

        
    }
}