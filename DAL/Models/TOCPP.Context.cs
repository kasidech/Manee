//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace Manee.INV.DAL.Models
{
    public partial class TOCPPContainer1 : ObjectContext
    {
        public const string ConnectionString = "name=TOCPPContainer1";
        public const string ContainerName = "TOCPPContainer1";
    
        #region Constructors
    
        public TOCPPContainer1()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public TOCPPContainer1(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public TOCPPContainer1(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<DeliveryNote> DeliveryNotes
        {
            get { return _deliveryNotes  ?? (_deliveryNotes = CreateObjectSet<DeliveryNote>("DeliveryNotes")); }
        }
        private ObjectSet<DeliveryNote> _deliveryNotes;
    
        public ObjectSet<ReceiptNote> ReceiptNotes
        {
            get { return _receiptNotes  ?? (_receiptNotes = CreateObjectSet<ReceiptNote>("ReceiptNotes")); }
        }
        private ObjectSet<ReceiptNote> _receiptNotes;
    
        public ObjectSet<NoteLineItem> NoteLineItems
        {
            get { return _noteLineItems  ?? (_noteLineItems = CreateObjectSet<NoteLineItem>("NoteLineItems")); }
        }
        private ObjectSet<NoteLineItem> _noteLineItems;
    
        public ObjectSet<Location> Locations
        {
            get { return _locations  ?? (_locations = CreateObjectSet<Location>("Locations")); }
        }
        private ObjectSet<Location> _locations;
    
        public ObjectSet<LocationType> LocationTypes
        {
            get { return _locationTypes  ?? (_locationTypes = CreateObjectSet<LocationType>("LocationTypes")); }
        }
        private ObjectSet<LocationType> _locationTypes;
    
        public ObjectSet<Worker> Workers
        {
            get { return _workers  ?? (_workers = CreateObjectSet<Worker>("Workers")); }
        }
        private ObjectSet<Worker> _workers;

        #endregion
    }
}
