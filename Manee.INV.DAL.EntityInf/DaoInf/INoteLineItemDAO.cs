﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOInf
{
    public interface INoteLineItemDAO
    {
        void CreateNoteLineItem(NoteLineItem item);
        void DeleteNoteLineItem(int id);
        void UpdateNoteLineItem(NoteLineItem item);

        List<NoteLineItem> FindNoteLineItemAll();
    

        
    }
}
