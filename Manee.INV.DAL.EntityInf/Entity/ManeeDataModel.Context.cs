﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ManeeDataContainer : DbContext
    {
        public ManeeDataContainer()
            : base("name=ManeeDataContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<DeliveryNote> DeliveryNotes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
        public DbSet<WorkerMethod> WorkerMethods { get; set; }
        public DbSet<NoteLineItem> NoteLineItems { get; set; }
        public DbSet<ReceiveNote> ReceiveNotes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<ItemStatus> ItemStatus { get; set; }
    }
}
