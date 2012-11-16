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

namespace Manee.INV.DB.Models
{
    public partial class Car
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual string Type
        {
            get;
            set;
        }
    
        public virtual string LicensePlateId
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<DeliveryNote> DeliveryNotes
        {
            get
            {
                if (_deliveryNotes == null)
                {
                    var newCollection = new FixupCollection<DeliveryNote>();
                    newCollection.CollectionChanged += FixupDeliveryNotes;
                    _deliveryNotes = newCollection;
                }
                return _deliveryNotes;
            }
            set
            {
                if (!ReferenceEquals(_deliveryNotes, value))
                {
                    var previousValue = _deliveryNotes as FixupCollection<DeliveryNote>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupDeliveryNotes;
                    }
                    _deliveryNotes = value;
                    var newValue = value as FixupCollection<DeliveryNote>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupDeliveryNotes;
                    }
                }
            }
        }
        private ICollection<DeliveryNote> _deliveryNotes;

        #endregion
        #region Association Fixup
    
        private void FixupDeliveryNotes(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (DeliveryNote item in e.NewItems)
                {
                    item.Car = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (DeliveryNote item in e.OldItems)
                {
                    if (ReferenceEquals(item.Car, this))
                    {
                        item.Car = null;
                    }
                }
            }
        }

        #endregion
    }
}
