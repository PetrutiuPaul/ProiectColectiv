using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProiectColectiv.Repository
{

    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> where);

        void Commit();

        T Get(Expression<Func<T, bool>> where);

        int Count();

        IQueryable<T> GetAll();

        IQueryable<T> GetMany(Expression<Func<T, bool>> where);

        IRepository<U> New<U>() where U : class;
    }
}
