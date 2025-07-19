using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using MasterContractApplication.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MasterContractApplication.Infrastructure
{
    public static class InfastructureDependencyRegister 
    {
        public static IServiceCollection AddInfastractureDI(this IServiceCollection services) 
        {
            services.AddDbContext<MasterContractApplicationContext>(option =>
            {
                option.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MasterContractApplication;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            });

            services.AddScoped<IUserRepository, UserRepositor>();

            return services;
        }
    }
}
