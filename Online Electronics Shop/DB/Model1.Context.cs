﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Electronics_Shop.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbOnlineElectronicsShopEntities : DbContext
    {
        public dbOnlineElectronicsShopEntities()
            : base("name=dbOnlineElectronicsShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Cart> Tbl_Cart { get; set; }
        public virtual DbSet<Tbl_CartStatus> Tbl_CartStatus { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_Members> Tbl_Members { get; set; }
        public virtual DbSet<Tbl_Product> Tbl_Product { get; set; }
        public virtual DbSet<Tbl_ShippingDetails> Tbl_ShippingDetails { get; set; }
        public virtual DbSet<SiteUser> SiteUsers { get; set; }
        public virtual DbSet<tbl_invoice> tbl_invoice { get; set; }
        public virtual DbSet<tbl_order> tbl_order { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
        public virtual DbSet<Tbl_OrderStatus> Tbl_OrderStatus { get; set; }
        public virtual DbSet<tbl_delivery> tbl_delivery { get; set; }
        public virtual DbSet<SiteAdmin> SiteAdmins { get; set; }
    }
}