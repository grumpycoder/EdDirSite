using EdDirSites.Core.Data.EntityConfigurations;
using EdDirSites.Core.Model;
using System;
using System.Data.Entity;

namespace EdDirSites.Core.Data
{
    public class EdContext : DbContext
    {
        public EdContext()
            : base("EdContext")
        {
            //Database.Log = msg => Debug.WriteLine(msg);
            Database.SetInitializer<EdContext>(null);
        }

        public DbSet<Site> Sites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar").HasMaxLength(255));
            modelBuilder.Properties<string>();

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("smalldatetime"));


            modelBuilder.Configurations.Add(new SiteConfiguration());

        }
    }
}
