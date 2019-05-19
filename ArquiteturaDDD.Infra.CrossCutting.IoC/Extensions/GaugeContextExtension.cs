using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Gauge.AutomationTest.Configuration;
using ArquiteturaDDD.Gauge.AutomationTest.Interfaces;
using ArquiteturaDDD.Gauge.AutomationTest.Steps;
using ArquiteturaDDD.Infra.Data.Repository.ProdutoRepo;
using Microsoft.Extensions.DependencyInjection;


namespace ArquiteturaDDD.Infra.CrossCutting.IoC.Extensions
{
    public static class GaugeContextExtension
    {
        public static IServiceCollection RegisterGaugeContext(this IServiceCollection services)
        {
            //services.AddSingleton<IProdutoStep, ProdutoStep>();
            //services.Scan(scan => scan
            //        .FromAssemblyOf<GaugeBase>()
            //            .AddClasses(classes => classes.Where(type => type.FullName.EndsWith("Step")))
            //                .AsSelf());

            return services;
        }
    }
}