﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.Service;
using Manee.INV.DAL.DAOInf;
using Manee.INV.DAL;
using Manee.INV.DAL.Entity;
using Manee.INV.Service.BL;

namespace Manee.INV.Service.ServiceImpl
{
    public class DeliveryNoteServiceImpl : IDeliveryNoteService
    {

        //private IDeliveryNoteDAO dao = (IDeliveryNoteDAO)DAOFactory.getDao("DELIVERY_NOTE");
        private IDeliveryNoteDAO dnDAO;


        public void CreateDeliveryNote(DeliveryNote dn)
        {
            //Business Logic Here


            dnDAO.Create(dn);


        }

        public void DeleteDeliveryNote(int noteId)
        {
            //Business Logic Here
            dnDAO.Delete(noteId);
        }

        public void UpdateDeliveryNote(DeliveryNote Note)
        {
            //Business Logic Here
            dnDAO.Update(Note);
        }
        public DeliveryNote FindDeliveryNoteById(int NoteId)
        {
            //Business Logic Here
            DeliveryNote result = dnDAO.FindById(NoteId);
            return result;
        }




        public List<DeliveryNote> FindDeliveryNoteByCriteria(DeliveryNote note)
        {
            throw new NotImplementedException();
        }

        public void SetStatusToItem(int dnId, int destinationId)
        {
            DeliveryNote deliveryNote = dnDAO.FindById(dnId);
            
            foreach (var item in deliveryNote.NoteLineItems)
            {
                if (deliveryNote.Destination.LocationType.Id == (int)DeliveryNoteBL.LocationType.store)
                {
                    item.Status = 2;
                }
                else {
                    item.Status = 1;
                }
                    
                
            }

            

        }
    }


}
