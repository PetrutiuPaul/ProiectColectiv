using Microsoft.EntityFrameworkCore;
using ProiectColectiv.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProiectColectiv.Repository
{
    public class GenericRepository<T> : IRepository<T>, IDisposable where T : class
    {
        protected ApplicationDbContext DataContext;
        protected DbSet<T> dbset;

        public GenericRepository(ApplicationDbContext dataContext)
        {
            this.DataContext = dataContext;
            this.dbset = DataContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            DataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
            {
                dbset.Remove(obj);
            }
        }

        public virtual void DeleteAll(string tableName)
        {
            dbset.RemoveRange(dbset);
            DataContext.SaveChanges();
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbset;
        }

        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
        public int Count()
        {
            return dbset.Count();
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }

        public void Dispose()
        {
            DataContext.Dispose();
        }


        public IRepository<U> New<U>() where U : class
            => new GenericRepository<U>(this.DataContext);

    }
}
