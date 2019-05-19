using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.ApplicationServices.Services.Base;
using ArquiteturaDDD.Domain.Builders;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.Data.Command.ProdutoCommands;
using ArquiteturaDDD.Infra.Data.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace ArquiteturaDDD.ApplicationServices.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        public ProdutoService(IMapper mapper, IProdutoRepository<Produto> produtoRepository) : base(mapper, produtoRepository) {  }

        public ProdutoViewModel GetById(long? id)
        {
            return _mapper.Map<ProdutoViewModel>(_repository.GetById(id));
        }

        public IEnumerable<ProdutoViewModel> GetProdutos()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(_repository.GetAll());
        }

        public void Insert(ProdutoViewModel produto)
        {
            var prod = new ProdutoBuilder(produto.Nome, produto.PrecoCusto, produto.PrecoVenda, produto.Marca)
                                    .AddDefaultInsert()
                                    .Build();

            new CommandInsertProduto(prod, (IProdutoRepository<Produto>)_repository).Execute();
        }

        public void Remove(long id)
        {
            _repository.Delete(id);
        }

        public void Update(ProdutoViewModel produto)
        {
            var prod = new ProdutoBuilder(produto.Nome, produto.PrecoCusto, produto.PrecoVenda, produto.Marca)
                                      .WithId(produto.Id)
                                      .AddDefaultUpdate()
                                      .Build();

            new CommandUpdateProduto(prod, (IProdutoRepository<Produto>)_repository).Execute();
        }
    }
}