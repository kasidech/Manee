//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DAL.Models
{
    public partial class NoteLineItem
    {
        #region Primitive Properties
    
        public virtual decimal Id
        {
            get;
            set;
        }
    
        public virtual string ItemCode
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Qty
        {
            get;
            set;
        }
    
        public virtual string Unit
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Status
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> DeliveryNoteId
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual DeliveryNotes DeliveryNotes
        {
            get { return _deliveryNotes; }
            set
            {
                if (!ReferenceEquals(_deliveryNotes, value))
                {
                    var previousValue = _deliveryNotes;
                    _deliveryNotes = value;
                    FixupDeliveryNotes(previousValue);
                }
            }
        }
        private DeliveryNotes _deliveryNotes;

        #endregion
        #region Association Fixup
    
        private void FixupDeliveryNotes(DeliveryNotes previousValue)
        {
            if (previousValue != null && previousValue.NoteLineItem.Contains(this))
            {
                previousValue.NoteLineItem.Remove(this);
            }
    
            if (DeliveryNotes != null)
            {
                if (!DeliveryNotes.NoteLineItem.Contains(this))
                {
                    DeliveryNotes.NoteLineItem.Add(this);
                }
            }
        }

        #endregion
    }
}
