using System.Linq;

namespace ImovelBens.Domain.Contracts.Repositories
{
    public interface IRepositoryBase<T> where T: class
    {
        void Add(T entity);
        void Update(T entity);

        void Delete(T entity);
        T GetById(int id);
        IQueryable<T> GetAll();

        void Commit();
       
    }
}
