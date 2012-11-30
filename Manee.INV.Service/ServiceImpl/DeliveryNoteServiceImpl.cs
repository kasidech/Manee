using System;
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
using LongkongStudio.Framework.Service;
using Spring.Context.Support;

namespace Manee.INV.Service.ServiceImpl
{
    public class DeliveryNoteServiceImpl : IDeliveryNoteService
    {

        private IDeliveryNoteDAO deliveryNoteDao = (IDeliveryNoteDAO)DAOFactory.GetDao("DELIVERY_NOTE");
        private ILocationDAO locationDao = (ILocationDAO)DAOFactory.GetDao("LOCATION");

        public void CreateDeliveryNote(DeliveryNote dn)
        {
            //Business Logic Here

            Location site = locationDao.FindLocationAll().Where(b=>b.Id==2).FirstOrDefault();
            deliveryNoteDao.CreateDeliveryNote(dn);


        }

        public void DeleteDeliveryNote(int noteId)
        {
            //Business Logic Here
            deliveryNoteDao.DeleteDeliveryNote(noteId);
        }

        public void UpdateDeliveryNote(DeliveryNote Note)
        {
            //Business Logic Here
            deliveryNoteDao.UpdateDeliveryNote(Note);
        }
        public DeliveryNote FindDeliveryNoteById(int NoteId)
        {
            //Business Logic Here
            DeliveryNote result = deliveryNoteDao.FindById(NoteId);
            return result;
        }




        public List<DeliveryNote> FindDeliveryNoteByCriteria(DeliveryNote note)
        {
            throw new NotImplementedException();
        }

        public void SetStatusToItem(int dnId, int destinationId)
        {
            DeliveryNote deliveryNote = deliveryNoteDao.FindById(dnId);
            
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
