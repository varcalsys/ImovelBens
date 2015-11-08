using System.Linq;
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;

namespace ImovelBens.Domain.Services
{
    public class ServiceBase<T>: IServiceBase<T> where T: class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Update(T entity)
        {
            _repositoryBase.Update(entity);
        }

        public void Delete(T entity)
        {
            _repositoryBase.Delete(entity);
        }

        public T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Commit()
        {
            _repositoryBase.Commit();
        }
    }
}
