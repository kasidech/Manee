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
    
    public partial class Worker
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Code { get; set; }
        public string IdCardNumber { get; set; }
    
        public virtual WorkerMethod WorkerMethod { get; set; }
    }
}