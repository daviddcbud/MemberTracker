﻿using MemberTracker.Models;
using System.Data.Entity.ModelConfiguration;

namespace MemberTracker.Data.Configuration
{
   public  class UserConfiguration:EntityTypeConfiguration<User>
    {
       public UserConfiguration()
       {
           this.Property((p) => p.Id).HasColumnOrder(0);
           this.Property((p) => p.LastName).IsRequired().HasMaxLength(50);
           this.Property((p) => p.FirstName).IsRequired().HasMaxLength(50);
           this.Property((p) => p.UserName).IsRequired().HasMaxLength(50);

           HasMany(p => p.Roles).WithMany(x => x.Users).Map(m =>
           {
               m.MapLeftKey("UserId");
               m.MapRightKey("RoleId");
               m.ToTable("webpages_UsersInRoles");
           });
       }
    }
}
