﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrarySalary.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SUPERPDEVEntities : DbContext
    {
        public SUPERPDEVEntities()
            : base("name=SUPERPDEVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<AbsenceType> AbsenceTypes { get; set; }
        public virtual DbSet<BILL_BillQuotation> BILL_BillQuotation { get; set; }
        public virtual DbSet<BILL_BillQuotationStatus> BILL_BillQuotationStatus { get; set; }
        public virtual DbSet<BILL_Category> BILL_Category { get; set; }
        public virtual DbSet<BILL_Product> BILL_Product { get; set; }
        public virtual DbSet<BILL_Status> BILL_Status { get; set; }
        public virtual DbSet<BILL_Transmitter> BILL_Transmitter { get; set; }
        public virtual DbSet<BILL_Vat> BILL_Vat { get; set; }
        public virtual DbSet<ConfigAbsence> ConfigAbsences { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Prime> Primes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleModule> RoleModules { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TicketRestaurant> TicketRestaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
