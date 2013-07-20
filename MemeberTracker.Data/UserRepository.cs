using MemberTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberTracker.Data
{
    public class UserRepository:GenericRepository<User>
    {
        public UserRepository(DbContext context):base(context)
        {

        }
    }
}
