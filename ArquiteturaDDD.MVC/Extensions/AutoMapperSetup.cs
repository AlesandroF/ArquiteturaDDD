using ArquiteturaDDD.Application.AutoMapper;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArquiteturaDDD.MVC.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            AutoMapperConfig.RegisterMappings();
        }
    }
}