using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.Data.Context;
using ArquiteturaDDD.Infra.Data.Interfaces;

namespace ArquiteturaDDD.Infra.Data.Repository.ProdutoRepo
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository<Produto> 
    {
        private readonly SQLContext _context;

        public ProdutoRepository(SQLContext context) : base(context)
        {
            _context = context;
        }
    }
}