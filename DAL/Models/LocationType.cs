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
    public partial class LocationType
    {
        #region Primitive Properties
    
        public virtual decimal Id
        {
            get;
            set;
        }
    
        public virtual string LocationTypeName
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Location Location
        {
            get { return _location; }
            set
            {
                if (!ReferenceEquals(_location, value))
                {
                    var previousValue = _location;
                    _location = value;
                    FixupLocation(previousValue);
                }
            }
        }
        private Location _location;

        #endregion
        #region Association Fixup
    
        private void FixupLocation(Location previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.LocationType, this))
            {
                previousValue.LocationType = null;
            }
    
            if (Location != null)
            {
                Location.LocationType = this;
            }
        }

        #endregion
    }
}
