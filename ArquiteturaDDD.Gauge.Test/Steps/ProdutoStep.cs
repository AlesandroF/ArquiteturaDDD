using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.ApplicationServices.Interfaces;
using Gauge.CSharp.Lib.Attribute;
using NUnit.Framework;

namespace ArquiteturaDDD.Gauge.AutomationTest.Steps
{
    public class ProdutoStep
    {
        //private readonly IProdutoService _produtoService;

        //public ProdutoStep(IProdutoService produtoService)
        //{
        //    _produtoService = produtoService;
        //}

        [Step("Criar um produto")]
        public void CriarProduto()
        {
            var produto = new ProdutoViewModel { Marca = "teste", Nome = "teste", PrecoCusto = 1, PrecoVenda = 5 };
           // _produtoService.Insert(produto);
        }

        [Test]
        public void ValidarTeste()
        {
            CriarProduto();
        }
    }
}