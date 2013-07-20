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
            base.Seed(context);
        }
    }
}
