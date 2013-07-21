using MemberTracker.Models;
using System.Data.Entity.ModelConfiguration;

namespace MemberTracker.Data.Configuration
{
    public class PersonConfiguration: EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            this.Property((p) => p.LastName).IsRequired().HasMaxLength(50);
            this.Property((p) => p.FirstName).IsRequired().HasMaxLength(50);
            this.Property((p) => p.MiddleName).IsOptional().HasMaxLength(50);
            this.Property((p) => p.Suffix).IsOptional().HasMaxLength(10);
            this.Property((p) => p.MailingAddressLines).IsOptional().HasMaxLength(100);
            this.Property((p) => p.City).IsOptional().HasMaxLength(50);
            this.Property((p) => p.State).IsOptional().HasMaxLength(20);
            this.Property((p) => p.Zip).IsOptional().HasMaxLength(20);
            this.Property((p) => p.HomePhone).IsOptional().HasMaxLength(20);
            this.Property((p) => p.CellPhone).IsOptional().HasMaxLength(20);
            this.Property((p) => p.WorkPhone).IsOptional().HasMaxLength(20);
            this.Property((p) => p.DateOfBirth).IsOptional().HasColumnType("date");
            this.Property((p) => p.CreatedOn).HasColumnType("datetime");
            this.Property((p) => p.ModifiedOn).HasColumnType("datetime"); 
        }
    }
}
