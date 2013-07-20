using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberTracker.Models;
using System.Data.Entity;
using System.Configuration;
using MemberTracker.Data.Configuration;
namespace MemberTracker.Data
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
         

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }
                return "DefaultConnection";
            }
        }
        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(p=>p.Entity is IAudit 
                && (p.State==  System.Data.EntityState.Added || p.State==   System.Data.EntityState.Modified)))
            {
                ((IAudit)entry).ModifiedOn=DateTime.Now;
                if(entry.State==  System.Data.EntityState.Added) ((IAudit)entry).CreatedOn=DateTime.Now;

            }

            return base.SaveChanges();
        }
         static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }
        public DataContext()
            : base(nameOrConnectionString: ConnectionStringName) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new MembershipConfiguration());
            modelBuilder.Configurations.Add(new  RolesConfiguration());
            modelBuilder.Configurations.Add(new OAuthMembershipConfiguration());

            //base.OnModelCreating(modelBuilder);
        }
    }
}
