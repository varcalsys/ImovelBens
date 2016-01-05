using System;
using System.Linq;
using System.Linq.Expressions;

namespace ImovelBens.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryBase<T>: IDisposable where T: class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Find(int id);
        T Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> Get();
        IQueryable<T> GetAsNoTracking(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAsNoTracking();

        void Commit();

        #region Async Methods

        //void AddAsync(T entity);
        //void UpdateAsync(T entity);
        //void DeleteAsync(T entity);
        //T FindAsync(int id);

        #endregion
    }
}
