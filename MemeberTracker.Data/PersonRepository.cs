using MemberTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberTracker.Data
{
    public class PersonRepository:GenericRepository<Person>
    {
        public PersonRepository(DbContext context):base(context)
        {

        }
    }
}
