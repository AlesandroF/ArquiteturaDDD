using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Infra.Data.Interfaces;
using ArquiteturaDDD.Infra.Data.Repository.ProdutoRepo;
using Microsoft.Extensions.DependencyInjection;

namespace ArquiteturaDDD.Infra.CrossCutting.IoC.Extensions
{
    public static class RepositoriesExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository<Produto>, ProdutoRepository>();

            return services;
        }
    }
}