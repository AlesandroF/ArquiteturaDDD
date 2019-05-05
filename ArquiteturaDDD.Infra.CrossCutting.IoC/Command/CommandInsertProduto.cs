using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.CrossCutting.IoC.Command.Base;
using ArquiteturaDDD.Infra.Data.Interfaces;

namespace ArquiteturaDDD.Infra.CrossCutting.IoC.Command
{
    public class CommandInsertProduto : BaseCommand
    {
        private readonly Produto _produto;
        private readonly IProdutoRepository<Produto> _userRepository;

        public CommandInsertProduto(Produto produto, IProdutoRepository<Produto> userRepository)
        {
            _produto = produto;
            _userRepository = userRepository;
        }

        protected override bool PreConditional()
        {
            //if (!string.IsNullOrEmpty(_produto.UserName) && !string.IsNullOrEmpty(_produto.Password))
            //{
            //    return true;
            //}
            return false;
        }

        protected override void Semantic()
        {
            _userRepository.Insert(_produto);
        }
    }
}