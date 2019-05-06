using ArquiteturaDDD.Domain.Builders;
using ArquiteturaDDD.Domain.Entities.Base;
using System;

namespace ArquiteturaDDD.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; private set; }
        public decimal PrecoCusto { get; private set; }
        public decimal PrecoVenda { get; private set; }
        public string Marca { get; private set; }

        public Produto() {  }

        public Produto(ProdutoBuilder produto)
        {
            Nome = SetNome(produto.Nome);
            PrecoCusto = SetPrecoCusto(produto.PrecoCusto);
            PrecoVenda = SetPrecoVenda(produto.PrecoVenda);
            Marca = SetMarca(produto.Marca);
            DataInclusao = SetDataInclusao(produto.DataInclusao);
            DataAlteracao = SetDataAlteracao(produto.DataAlteracao);
            CodigoUsuario = SetCodigoUsuario(produto.CodigoUsuario);
        }

        public Produto(string nome, string marca, decimal custo, decimal venda)
        {
            Nome = SetNome(nome);
            PrecoCusto = SetPrecoCusto(custo);
            PrecoVenda = SetPrecoVenda(venda);
            Marca = SetMarca(marca);
            DataInclusao = SetDataInclusao(DateTime.Now);
            DataAlteracao = SetDataAlteracao(DateTime.Now);
            CodigoUsuario = SetCodigoUsuario(13);
        }

        private string SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) return string.Empty;
            return nome;
        }

        private decimal SetPrecoCusto(decimal precoCusto)
        {
            if (precoCusto < 0) return 0;
            return precoCusto;
        }

        private decimal SetPrecoVenda(decimal precoVenda)
        {
            if (precoVenda < 1) return 1;
            return precoVenda;
        }

        private string SetMarca(string marca)
        {
            if (string.IsNullOrEmpty(marca)) return string.Empty;
            return marca;
        }
    }
}