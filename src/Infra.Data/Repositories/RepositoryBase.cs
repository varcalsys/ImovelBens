﻿using System.Data.Entity;
using System.Linq;
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Infra.Data.AppContext;

namespace ImovelBens.Infra.Data.Repositories
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T: class
    {
        protected readonly ImovelBensContext _context;

        public RepositoryBase()
        {
            _context = new ImovelBensContext();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}