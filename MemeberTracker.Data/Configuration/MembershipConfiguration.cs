using MemeberTracker.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace MemeberTracker.Data.Configuration
{
   public class MembershipConfiguration:EntityTypeConfiguration<Membership>
    {
       public MembershipConfiguration()
       {
           ToTable("webpages_Membership");
           HasKey(p => p.UserId);
           Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
           Property(p => p.ConfirmationToken).HasMaxLength(128).HasColumnType("nvarchar");
           Property(p => p.PasswordFailureSinceLastSuccess).IsRequired();
           Property(p => p.Password).IsRequired();
           Property(p => p.PasswordSalt).IsRequired().HasMaxLength(128).HasColumnType("nvarchar");
           Property(p => p.PasswordVerificationToken).HasMaxLength(128).HasColumnType("nvarchar");

       }
    }
}
