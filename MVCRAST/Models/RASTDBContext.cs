using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCRAST.Models
{
    public class RASTDBContext : DbContext
    {
        public RASTDBContext() : base ("name=RASTDBContext")
        {
        }
        public DbSet<MVCRAST.Models.Artifact> Artifacts { get; set; }
        public DbSet<MVCRAST.Models.Controls> Controls { get; set; }
        public DbSet<MVCRAST.Models.FamilyControl> FamilyControls { get; set; }
        public DbSet<MVCRAST.Models.FileTemplate> FileTemplates { get; set; }
        public DbSet<MVCRAST.Models.Organization> Organizations { get; set; }
        public DbSet<MVCRAST.Models.POAM> POAMs { get; set; }
        public DbSet<MVCRAST.Models.POAMItem> POAMItems { get; set; }
        public DbSet<MVCRAST.Models.SAP> SAPs { get; set; }
        public DbSet<MVCRAST.Models.SystemControl> SystemControls { get; set; }
        public DbSet<MVCRAST.Models.Systems> Systems { get; set; }
        public DbSet<MVCRAST.Models.User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}