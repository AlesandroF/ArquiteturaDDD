using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.Data.Interfaces;

namespace ArquiteturaDDD.ApplicationServices.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository<Produto> _produtoRepository;

        public ProdutoService(IProdutoRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void InsertUser(Produto produto)
        {
            //var insertUser = new CommandInsertUser(_userBuilder.From(user).Build(), _userRepository);
            //insertUser.Execute();
        }
    }
}