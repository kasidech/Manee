﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.DAOInf;
using System.Data.Entity;
using Manee.INV.DAL.Entity;

namespace Manee.INV.DAL.DAOImpl
{
    class ReceiveNoteDAOImpl: IReceiveNoteDAO
    {
        private ManeeDataContainer context = new ManeeDataContainer();
        public void Create(Entity.ReceiveNote note)
        {
            
            context.ReceiveNotes.Add(note);
            context.SaveChanges();
        }

        public void Delete(int noteId)
        {
            var receiveNote = context.ReceiveNotes.FirstOrDefault(r => r.Id == noteId);
            context.ReceiveNotes.Remove(receiveNote);
            context.SaveChanges();

        }

        public void Update(Entity.ReceiveNote note)
        {
            var receiveNote = context.ReceiveNotes.FirstOrDefault(r => r.Id == note.Id);
            receiveNote.ReceiverCode = note.ReceiverCode;
            receiveNote.Code = note.Code;
            receiveNote.ReceiveDate = note.ReceiveDate;
            receiveNote.ReceiverName = note.ReceiverName;           

            context.SaveChanges();
        }

        public Entity.ReceiveNote FindById(int id)
        {
            return context.ReceiveNotes.FirstOrDefault(r => r.Id == id);
        }

        public List<Entity.ReceiveNote> FindByCriteria(Entity.ReceiveNote noteCriteria)
        {
            return new List<ReceiveNote>();
        }

       
    }
}
