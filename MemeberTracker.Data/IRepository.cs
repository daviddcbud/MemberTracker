using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeberTracker.Data
{
    public interface IRepository<T> where  T: class 
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(int id);
        void Delete(T Entity);
        void Detach(T Entity);

    }
}
