using ArquiteturaDDD.Infra.Data.Context;
using ArquiteturaDDD.Infra.Data.Interfaces.Base;
using System;
using System.Collections.Generic;

namespace ArquiteturaDDD.Infra.Data.Repository
{
    public abstract class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly SQLContext _context;

        public BaseRepository(SQLContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int key)
        {
            return _context.Set<T>().Find(key);
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            SaveAll();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
            SaveAll();
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            SaveAll();
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}