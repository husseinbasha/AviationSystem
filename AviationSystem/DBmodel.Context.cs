﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AviationSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ATSEntity : DbContext
    {
        public ATSEntity()
            : base("name=ATSEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<ATO> ATOes { get; set; }
        public virtual DbSet<DiplomaticPermit> DiplomaticPermits { get; set; }
        public virtual DbSet<Emp_ATC> Emp_ATC { get; set; }
        public virtual DbSet<LandingPermit> LandingPermits { get; set; }
        public virtual DbSet<LandingTakeoffPermit> LandingTakeoffPermits { get; set; }
        public virtual DbSet<OverFlyPermit> OverFlyPermits { get; set; }
        public virtual DbSet<ScheduledFlight> ScheduledFlights { get; set; }
        public virtual DbSet<ScheduledPermitData> ScheduledPermitDatas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
