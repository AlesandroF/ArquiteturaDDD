using System.Collections.Generic;

namespace ArquiteturaDDD.Infra.Data.Interfaces.Base
{
    public interface IBaseRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(long? key);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(long id);
    }
}