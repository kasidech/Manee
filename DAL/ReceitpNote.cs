//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manee.INV.DAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceitpNote
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public string ReceiverCode { get; set; }
        public string ReceiverName { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
    
        public virtual DeliveryNote DeliveryNote { get; set; }
    }
}
