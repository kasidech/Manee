using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.Service;
using System.Data.Entity;
using DAL;

namespace Manee.INV.Service.DeliveryNoteService
{
    public class DeliveryNoteService:BaseService
    {
        public void CreateDeliveryNote() {

            DeliveryNote dn = new DeliveryNote() ;
            
            
            db.DeliveryNotes.Add(dn);
            db.SaveChanges();
                
            
        }

        public void DeleteDeliveryNote() {

            DeliveryNote dn = new DeliveryNote();

            db.DeliveryNotes.Remove(dn);

        }
    }
}
