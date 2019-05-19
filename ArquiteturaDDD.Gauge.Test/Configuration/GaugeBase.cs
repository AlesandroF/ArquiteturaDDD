using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.ApplicationServices.Interfaces.Base;
using ArquiteturaDDD.Domain.Entities.Base;
using AutoMapper;

namespace ArquiteturaDDD.Gauge.AutomationTest.Configuration
{
    public class GaugeBase : IBaseGauge
    {
        protected readonly IProdutoService _produtoService;

        public GaugeBase(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
    }
}