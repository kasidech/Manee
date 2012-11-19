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
    public partial class Location
    {
        #region Primitive Properties
    
        public virtual decimal Id
        {
            get;
            set;
        }
    
        public virtual string Code
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual decimal LocationTypeId
        {
            get;
            set;
        }
    
        public virtual string Address
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> ProjectManagerId
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual LocationType LocationType
        {
            get { return _locationType; }
            set
            {
                if (!ReferenceEquals(_locationType, value))
                {
                    var previousValue = _locationType;
                    _locationType = value;
                    FixupLocationType(previousValue);
                }
            }
        }
        private LocationType _locationType;

        #endregion
        #region Association Fixup
    
        private void FixupLocationType(LocationType previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.Location, this))
            {
                previousValue.Location = null;
            }
    
            if (LocationType != null)
            {
                LocationType.Location = this;
            }
        }

        #endregion
    }
}