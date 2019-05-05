using System.Collections.Generic;

namespace ArquiteturaDDD.Infra.Data.Interfaces.Base
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int key);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}