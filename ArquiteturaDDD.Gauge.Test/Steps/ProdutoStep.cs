using Gauge.CSharp.Lib.Attribute;
using NUnit.Framework;

namespace ArquiteturaDDD.Gauge.AutomationTest.Steps
{
    public class ProdutoStep
    {
        [Step("O cliente <cnpj> deve possuir uma meta de mix gold de <valorMeta>")]
        public void CheckMetaMixGoldCliente(string valorMeta)
        {
        }


        [Test]
        public void teste()
        {

        }
    }
}