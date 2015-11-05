using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NettButikk_Oppg2.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace NettButikk_Oppg2.DAL
{
    public class ButikkContext : DbContext
    {
        public ButikkContext() : base("KunderEntities")
        {
            Database.SetInitializer<ButikkContext>(null);
            Database.CreateIfNotExists();
        }

        public DbSet<Bestilling> Bestillinger { get; set; }
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Vare> Varer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}