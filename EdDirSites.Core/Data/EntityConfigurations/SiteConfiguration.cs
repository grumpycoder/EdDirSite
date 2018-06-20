using EdDirSites.Core.Model;
using System.Data.Entity.ModelConfiguration;

namespace EdDirSites.Core.Data.EntityConfigurations
{
    public class SiteConfiguration : EntityTypeConfiguration<Site>
    {
        public SiteConfiguration()
        {
            ToTable("EdDir.Site");
            Property(s => s.Id).HasColumnName("SiteID");
            //Property(s => s.FileNameFormat).HasMaxLength(50);
            //Property(s => s.DueDate).HasColumnType("datetime2");

        }
    }
}
