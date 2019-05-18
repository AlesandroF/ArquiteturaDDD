using ArquiteturaDDD.Domain.Builders.Base;
using ArquiteturaDDD.Domain.Entities;
using System;

namespace ArquiteturaDDD.Domain.Builders
{
    public class ProdutoBuilder : BaseBuilder
    {
        public string Nome { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public string Marca { get; set; }

        public ProdutoBuilder(string nome, decimal precoCusto, decimal precoVenda, string marca)
        {
            Nome = nome;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            Marca = marca;
        }

        public ProdutoBuilder AddDefaultInsert()
        {
            DataInclusao = DateTime.Now;
            CodigoUsuario = 12;
            return this;
        }

        public ProdutoBuilder AddDefaultUpdate()
        {
            DataAlteracao = DateTime.Now;
            CodigoUsuario = 12;
            return this;
        }

        public ProdutoBuilder WithId(long id)
        {
            Id = id;
            return this;
        }

        public Produto Build()
        {
            return new Produto(this);
        }
    }
}
