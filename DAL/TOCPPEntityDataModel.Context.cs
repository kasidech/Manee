﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TOCPPEntities : DbContext
    {
        public TOCPPEntities()
            : base("name=TOCPPEntities")
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
        public DbSet<Method> Methods { get; set; }
        public DbSet<NoteLineItemSet> NoteLineItemSets { get; set; }
        public DbSet<ReceitpNote> ReceitpNotes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
