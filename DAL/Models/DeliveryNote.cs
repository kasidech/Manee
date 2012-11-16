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

namespace Manee.INV.DAL.Models
{
    public partial class DeliveryNote
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual string SenderName
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> OriginId
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> DestinationId
        {
            get;
            set;
        }
    
        public virtual string DriverName
        {
            get;
            set;
        }
    
        public virtual string CarLicensePlate
        {
            get;
            set;
        }
    
        public virtual string Cartype
        {
            get;
            set;
        }
    
        public virtual string SenderCode
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ReceiptNote ReceiptNote
        {
            get { return _receiptNote; }
            set
            {
                if (!ReferenceEquals(_receiptNote, value))
                {
                    var previousValue = _receiptNote;
                    _receiptNote = value;
                    FixupReceiptNote(previousValue);
                }
            }
        }
        private ReceiptNote _receiptNote;
    
        public virtual ICollection<NoteLineItem> NoteLineItems
        {
            get
            {
                if (_noteLineItems == null)
                {
                    var newCollection = new FixupCollection<NoteLineItem>();
                    newCollection.CollectionChanged += FixupNoteLineItems;
                    _noteLineItems = newCollection;
                }
                return _noteLineItems;
            }
            set
            {
                if (!ReferenceEquals(_noteLineItems, value))
                {
                    var previousValue = _noteLineItems as FixupCollection<NoteLineItem>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupNoteLineItems;
                    }
                    _noteLineItems = value;
                    var newValue = value as FixupCollection<NoteLineItem>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupNoteLineItems;
                    }
                }
            }
        }
        private ICollection<NoteLineItem> _noteLineItems;

        #endregion
        #region Association Fixup
    
        private void FixupReceiptNote(ReceiptNote previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.DeliveryNote, this))
            {
                previousValue.DeliveryNote = null;
            }
    
            if (ReceiptNote != null)
            {
                ReceiptNote.DeliveryNote = this;
            }
        }
    
        private void FixupNoteLineItems(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (NoteLineItem item in e.NewItems)
                {
                    item.DeliveryNote = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (NoteLineItem item in e.OldItems)
                {
                    if (ReferenceEquals(item.DeliveryNote, this))
                    {
                        item.DeliveryNote = null;
                    }
                }
            }
        }

        #endregion
    }
}