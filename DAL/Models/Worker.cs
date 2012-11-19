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
    public partial class Worker
    {
        #region Primitive Properties
    
        public virtual decimal Id
        {
            get;
            set;
        }
    
        public virtual string FullName
        {
            get;
            set;
        }
    
        public virtual string Code
        {
            get;
            set;
        }
    
        public virtual string IdCardNumber
        {
            get;
            set;
        }
    
        public virtual decimal MethodId
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Method Method
        {
            get { return _method; }
            set
            {
                if (!ReferenceEquals(_method, value))
                {
                    var previousValue = _method;
                    _method = value;
                    FixupMethod(previousValue);
                }
            }
        }
        private Method _method;

        #endregion
        #region Association Fixup
    
        private void FixupMethod(Method previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.Worker, this))
            {
                previousValue.Worker = null;
            }
    
            if (Method != null)
            {
                Method.Worker = this;
            }
        }

        #endregion
    }
}
