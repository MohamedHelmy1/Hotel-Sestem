//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.CustomerRooms = new HashSet<CustomerRoom>();
        }
    
        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public Nullable<int> RoomType { get; set; }
        public Nullable<bool> Pass { get; set; }
        public Nullable<System.DateTime> checkIn { get; set; }
        public Nullable<System.DateTime> CheakOut { get; set; }
        public Nullable<double> prise { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRoom> CustomerRooms { get; set; }
        public virtual RoomType RoomType1 { get; set; }
    }
}