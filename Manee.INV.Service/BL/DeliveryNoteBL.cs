using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manee.INV.DAL.Entity;

namespace Manee.INV.Service.BL
{
    public class DeliveryNoteBL
    {
        //1 = ready

        public enum ItemStatus :int  { ready = 1, normal};
        public enum LocationType : int { store = 1, site };
   
    //{Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};
        
        /// <summary>
        /// Check Item ใน Stock
        /// </summary>
        /// <param name="noteLineItem"></param>
        /// <returns></returns>
        public bool HasItemInStock(List<NoteLineItem> noteLineItem) {
            return false;
        }

        /// <summary>
        /// Check Item สามารถจ่ายได้หรือไม่
        /// </summary>
        /// <returns></returns>
        //public bool CheckItemMoveAble(List<NoteLineItem> noteLineItems)
        //{
        //    //1. เช็ค Item Status 
        //    //2. เช็ค Item Quantity
        //    //3. เช็ค Item Location
        //    if (noteLineItems != null)
        //    {
        //        foreach (var item in noteLineItems)
        //        {
        //            if (CheckItemStatus(item.Status))
        //            {
        //                if (CheckItemQuantity(QuantityInStock, item.Quantity))
        //                {
        //                    if (CheckItemLocation(item.location.Id, userLocation))
        //                    {
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
                
        //    }
        //    return false;
        //}


        private bool CheckItemStatus(int status)
        {
            if(status == (int)ItemStatus.ready){
                return true;
            }
            return false;
        }

        private bool CheckItemQuantity(int QuantityInStock, int ItemQuantity)
        {
            if (ItemQuantity <= QuantityInStock)
            {
                return true;
            }
            return false;
        }

        private bool CheckItemLocation(int itemLocation,int userLocation)
        {
            if (itemLocation == userLocation)
            {
                return true;
            }
            return false;
        }
    }

}
