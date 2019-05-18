using ArquiteturaDDD.Domain.Interfaces.Data;
using ArquiteturaDDD.Infra.Data.Context;

namespace ArquiteturaDDD.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SQLContext _context;

        public UnitOfWork(SQLContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}