using ArquiteturaDDD.Domain.Entities.Base;

namespace ArquiteturaDDD.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public string Marca { get; set; }

        public Produto() {  }

        public Produto(string nome, decimal precoCusto, decimal precoVenda, string marca)
        {
            Nome = SetNome(nome);
            PrecoCusto = SetPrecoCusto(precoCusto);
            PrecoVenda = SetPrecoVenda(precoVenda);
            Marca = SetMarca(marca);
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