using ArquiteturaDDD.Domain.Entities.Base;

namespace ArquiteturaDDD.ApplicationServices.Interfaces.Base
{
    public interface IBaseService<T> where T : Entity
    {
    }
}