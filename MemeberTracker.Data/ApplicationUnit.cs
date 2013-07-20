using MemberTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberTracker.Data
{
    public class ApplicationUnit:IDisposable
    {
        DataContext _context = new DataContext();
        IRepository<Person> _personRepository;
        IRepository<User> _userRepository;
        public IRepository<User> UserRepo
        {
            get
            {
                if (_userRepository == null) _userRepository = new UserRepository(_context);
                return _userRepository;
            }
        }
        public IRepository<Person> PersonRepo
        {
            get
            {
                if (_personRepository == null) _personRepository = new PersonRepository(_context);
                return _personRepository;
            }
        }
        public ApplicationUnit()
        {
            

        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }
    }
}
