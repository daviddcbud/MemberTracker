using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MemeberTracker.Models;

namespace MemeberTracker.Data.Configuration
{
    public class CustomDatabaseInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //no need for savechanges
            var role = new Role();
            role.RoleName = "Administrator";
            context.Roles.Add(role);
            base.Seed(context);
        }
    }
}
