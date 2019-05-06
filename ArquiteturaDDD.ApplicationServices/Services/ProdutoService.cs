using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.Domain.Builders;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.Data.Command.ProdutoCommands;
using ArquiteturaDDD.Infra.Data.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace ArquiteturaDDD.ApplicationServices.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository<Produto> _produtoRepository;

        public ProdutoService(IMapper mapper, IProdutoRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public ProdutoViewModel GetById(long? id)
        {
            return _mapper.Map<ProdutoViewModel>(_produtoRepository.GetById(id));
        }

        public IEnumerable<ProdutoViewModel> GetProdutos()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.GetAll());
        }

        public void Insert(ProdutoViewModel produto)
        {
            var prod = new ProdutoBuilder(produto.Nome, produto.PrecoCusto, produto.PrecoVenda, produto.Marca)
                                    .AddDefaultInsert()
                                    .Build();

            new CommandInsertProduto(prod, _produtoRepository).Execute();
        }

        public void Remove(long id)
        {
            _produtoRepository.Delete(id);
        }

        public void Update(ProdutoViewModel produto)
        {
            //var prod = new ProdutoBuilder(produto.Nome, produto.PrecoCusto, produto.PrecoVenda, produto.Marca)
            //                          .AddDefaultUpdate()
            //                          .Build();
            var prod = _mapper.Map<Produto>(produto);

            new CommandUpdateProduto(prod, _produtoRepository).Execute();
        }
    }
}