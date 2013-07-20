using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MemberTracker.Models;

namespace MemberTracker.Data.Configuration
{
    public class CustomDatabaseInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //no need for savechanges
            var role = new Role();
            role.RoleName = "Administrator";
            context.Roles.Add(role);

            CreateIndex(context, "UserName", "Users",true);
            CreateIndex(context, "LastName", "People", false);
            CreateIndex(context, "FirstName", "People", false);
            base.Seed(context);
        }
        private void CreateIndex(DataContext context, string field, string table, bool unique = false)
        {
            context.Database.ExecuteSqlCommand(String.Format("CREATE {0}NONCLUSTERED INDEX IX_{1}_{2} ON {1} ({3})",
                unique ? "UNIQUE " : "",
                table,
                field.Replace(",", "_"),
                field));
        } 
    }
}
