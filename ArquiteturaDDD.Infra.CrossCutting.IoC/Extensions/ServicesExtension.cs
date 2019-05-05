using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.ApplicationServices.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArquiteturaDDD.Infra.CrossCutting.IoC.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}