using AutoMapper;
using Fecomercio.Application.Implementations;
using Fecomercio.Application.Interfaces;
using Fecomercio.Application.Mappings;
using Fecomercio.Data.Context;
using Fecomercio.Data.Repository;
using Fecomercio.Domain.Interfaces.Repository;
using Fecomercio.Domain.Interfaces.Services;
using Fecomercio.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fecomercio.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<FecomercioContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionStringFecomercio")));

            services.AddScoped<IBoletoRepository, BoletoRepository>();
            services.AddScoped<ICobrancaRepository, CobrancaRepository>();
            services.AddScoped<IComissaoRepository, ComissaoRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBoletoService, BoletoService>();
            services.AddScoped<ICobrancaService, CobrancaService>();
            services.AddScoped<IComissaoService, ComissaoService>();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToDtoMapping));
            services.AddAutoMapper(typeof(DtoToDomainMapping));
            services.AddScoped<IBoletoApplicationService, BoletoApplicationService>();
            services.AddScoped<ICobrancaApplicationService, CobrancaApplicationService>();
            services.AddScoped<IComissaoApplicationService, ComissaoApplicationService>();

            return services;
        }
    }
}