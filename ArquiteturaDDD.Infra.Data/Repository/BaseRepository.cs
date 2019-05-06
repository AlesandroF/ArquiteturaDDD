using ArquiteturaDDD.Infra.Data.Context;
using ArquiteturaDDD.Infra.Data.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ArquiteturaDDD.Infra.Data.Repository
{
    public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SQLContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(SQLContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return DbSet;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntity GetById(long? id)
        {
            try
            {
                return DbSet.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(TEntity obj)
        {
            try
            {
                DbSet.Add(obj);
                SaveAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                DbSet.Update(obj);
                SaveAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {
            try
            {
                DbSet.Remove(DbSet.Find(id));
                SaveAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}