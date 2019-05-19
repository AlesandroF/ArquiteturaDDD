using ArquiteturaDDD.Domain.Entities.Base;
using ArquiteturaDDD.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using ArquiteturaDDD.ApplicationServices.Services.Base;


namespace ArquiteturaDDD.Infra.CrossCutting.IoC.Extensions
{
    public static class GaugeContextExtension
    {
        public static IServiceCollection RegisterGaugeContext(this IServiceCollection services)
        {
            services.Scan(scan => scan
                      .FromAssemblyOf<BaseRepository<Entity>>()
                          .AddClasses(classes => classes.Where(type => type.FullName.EndsWith("Repository")))
                              .AsSelf()
                              .WithScopedLifetime()
                                .AddClasses(classes => classes.Where(type => type.FullName.EndsWith("Service")))
                                    .AsSelf()
                                    .WithScopedLifetime().FromAssemblyOf<BaseService<Entity>>());

            return services;
        }
    }
}