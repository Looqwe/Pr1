﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pr1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Pr1Entities : DbContext
    {
        public Pr1Entities()
            : base("name=Pr1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Mode> Mode { get; set; }
        public virtual DbSet<RepairOfTheDevice> RepairOfTheDevice { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Verification> Verification { get; set; }
    }
}