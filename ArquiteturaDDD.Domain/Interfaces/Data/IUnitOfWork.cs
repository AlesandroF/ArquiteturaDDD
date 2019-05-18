using System;

namespace ArquiteturaDDD.Domain.Interfaces.Data
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}