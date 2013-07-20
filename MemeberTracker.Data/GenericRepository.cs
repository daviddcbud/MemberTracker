using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MemberTracker.Data
{
    public class GenericRepository<T>:IRepository<T> where T:class 
    {
        protected DbSet<T> DbSet { get; set; }
        protected DbContext Context { get; set; }
        public GenericRepository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T Entity)
        {
            var entry = Context.Entry(Entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(Entity);
            }
        }

        public void Update(T Entity)
        {
            var entry = Context.Entry(Entity);
            if (entry.State == EntityState.Detached)
            {
                DbSet.Attach(Entity);
            }
             
            entry.State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null) Delete(entity);
        }

        public void Delete(T Entity)
        {
            var entry = Context.Entry(Entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(Entity);
                DbSet.Remove(Entity);
            }
        }

        public void Detach(T Entity)
        {
            var entry = Context.Entry(Entity);
            entry.State = EntityState.Detached;
        }
    }
}
