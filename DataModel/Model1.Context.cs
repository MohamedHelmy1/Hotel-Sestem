﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Hotel_SystemEntities : DbContext
    {
        public Hotel_SystemEntities()
            : base("name=Hotel_SystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<Complait> Complaits { get; set; }
        public virtual DbSet<CustomerRoom> CustomerRooms { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<EmployementType> EmployementTypes { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<ShiftType> ShiftTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<vister> visters { get; set; }
    }
}
