using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.Data.Command.Base;
using ArquiteturaDDD.Infra.Data.Interfaces;

namespace ArquiteturaDDD.Infra.Data.Command.ProdutoCommands
{
    public class CommandUpdateProduto : BaseCommand
    {
        private readonly Produto _produto;
        private readonly IProdutoRepository<Produto> _produtoRepository;

        public CommandUpdateProduto(Produto produto, IProdutoRepository<Produto> produtoRepository)
        {
            _produto = produto;
            _produtoRepository = produtoRepository;
        }

        protected override bool PreConditional() => _produto != null ? true : false;

        protected override void Semantic()
        {
            _produtoRepository.Update(_produto);
        }
    }
}