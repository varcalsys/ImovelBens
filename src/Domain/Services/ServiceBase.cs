using System;
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
            try
            {
                _repositoryBase.Add(entity);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }

        public void Update(T entity)
        {
            try
            {
                _repositoryBase.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                _repositoryBase.Delete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

            try
            {
                _repositoryBase.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
