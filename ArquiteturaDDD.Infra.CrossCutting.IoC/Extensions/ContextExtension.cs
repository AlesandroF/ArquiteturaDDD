using ArquiteturaDDD.Infra.CrossCutting.IoC.Settings;
using ArquiteturaDDD.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace ArquiteturaDDD.Infra.CrossCutting.IoC.Extensions
{
    public static class ContextExtension
    {
        public static IServiceCollection RegisterContexts(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddScoped<SQLContext>();

            return services;
        }
    }
}