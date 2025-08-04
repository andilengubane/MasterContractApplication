using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Domain.Options;
using MasterContractApplication.Infrastructure.Data;
using MasterContractApplication.Infrastructure.Repositories;
using MasterContractApplication.Infrastructure.Services;
using MasterContractApplication.Infrastructure.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace MasterContractApplication.Infrastructure
{
    public static class InfastructureDependencyRegister 
    {
        public static IServiceCollection AddInfastractureDI(this IServiceCollection services) 
        {
            services.AddDbContext<MasterContractApplicationContext>((provider ,option) =>
            {
                option.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectioStringOptions>>().Value.DefaultConnection);
            });

            services.AddScoped<IUserRepository, UserRepositor>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IExternalVenderRepository, ContextHttpClientService>();

            //TODO : adding base to the appsettings file.
            services.AddHttpClient<IContextHttpClientService, ContextHttpClientService>(option => 
            {
                option.BaseAddress = new Uri("base address");
            });

            return services;
        }
    }
}
