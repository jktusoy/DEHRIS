﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEHRISDataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEHRISEntities1 : DbContext
    {
        public DEHRISEntities1()
            : base("name=DEHRISEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ais_cdtransactiondetails> ais_cdtransactiondetails { get; set; }
        public virtual DbSet<common_importtempate> common_importtempate { get; set; }
        public virtual DbSet<common_importtemplatedetail> common_importtemplatedetail { get; set; }
        public virtual DbSet<common_importtransaction> common_importtransaction { get; set; }
        public virtual DbSet<common_importtransactiondetail> common_importtransactiondetail { get; set; }
        public virtual DbSet<hris_address> hris_address { get; set; }
        public virtual DbSet<hris_birform2305> hris_birform2305 { get; set; }
        public virtual DbSet<hris_employment> hris_employment { get; set; }
        public virtual DbSet<hris_personnel> hris_personnel { get; set; }
        public virtual DbSet<pm_project> pm_project { get; set; }
        public virtual DbSet<pm_projectaccess> pm_projectaccess { get; set; }
        public virtual DbSet<sis_school> sis_school { get; set; }
        public virtual DbSet<sis_schooldistrict> sis_schooldistrict { get; set; }
        public virtual DbSet<ais_cdtransaction> ais_cdtransaction { get; set; }
    }
}
