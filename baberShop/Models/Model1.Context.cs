﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baberShop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BARBERSHOPEntities8 : DbContext
    {
        public BARBERSHOPEntities8()
            : base("name=BARBERSHOPEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT_USER> ACCOUNT_USER { get; set; }
        public virtual DbSet<BOOKING> BOOKINGs { get; set; }
        public virtual DbSet<INFOR_SHOP> INFOR_SHOP { get; set; }
        public virtual DbSet<INFOUSER> INFOUSERs { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SERVICE_SHOP> SERVICE_SHOP { get; set; }
    }
}
