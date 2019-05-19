using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.ApplicationServices.Services;
using ArquiteturaDDD.Infra.Data.Context;
using ArquiteturaDDD.Infra.Data.Repository.ProdutoRepo;
using Gauge.CSharp.Lib.Attribute;
using NUnit.Framework;

namespace ArquiteturaDDD.Gauge.AutomationTest.Steps
{
    public class ProdutoStep //: GaugeBase
    {
        [Step("Criar um produto")]
        public void CriarProduto()
        {
            var _produtoService = new ProdutoService(null, new ProdutoRepository(new SQLContext()));
            var produto = new ProdutoViewModel { Marca = "teste", Nome = "teste", PrecoCusto = 1, PrecoVenda = 5 };
            _produtoService.Insert(produto);
            var produtoteste = _produtoService.GetById(10004);

            Assert.NotNull(produtoteste);
        }

        [Test]
        public void ValidarTeste()
        {
            CriarProduto();
        }
    }
}