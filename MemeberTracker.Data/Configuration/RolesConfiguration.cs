using MemeberTracker.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace MemeberTracker.Data.Configuration
{
    class RolesConfiguration:EntityTypeConfiguration<Role>
    {
        public RolesConfiguration()
        {
            ToTable("webpages_Roles");
            Property(p => p.RoleName).HasMaxLength(256).IsRequired();
        }
    }
}
