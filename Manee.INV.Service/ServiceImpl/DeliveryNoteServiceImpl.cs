using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service.ServiceInf;
using Manee.INV.Service;
using Manee.INV.DAL.DaoInf;
using Manee.INV.DAL;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.ServiceImpl
{
    public class DeliveryNoteServiceImpl : IDeliveryNoteService
    {

        private IDeliveryNoteDAO dao = (IDeliveryNoteDAO)DAOFactory.getDao("DELIVERY_NOTE");

        public void CreateDeliveryNote(DeliveryNote dn)
        {
            //Business Logic Here


            dao.Create(dn);


        }

        public void DeleteDeliveryNote(int noteId)
        {
            //Business Logic Here
            dao.Delete(noteId);
        }

        public void UpdateDeliveryNote(DeliveryNote Note)
        {
            //Business Logic Here
            dao.Update(Note);
        }
        public DeliveryNote FindDeliveryNoteById(int NoteId)
        {
            //Business Logic Here
            DeliveryNote result = dao.FindById(NoteId);
            return result;
        }




        public List<DeliveryNote> FindDeliveryNoteByCriteria(DeliveryNote note)
        {
            throw new NotImplementedException();
        }
    }


}
