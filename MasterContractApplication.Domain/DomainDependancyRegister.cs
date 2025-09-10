using MasterContractApplication.Domain.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MasterContractApplication.Domain
{
    public static class DomainDependancyRegister
    {
        public static IServiceCollection AddDomainID(this IServiceCollection services, IConfiguration configuration) 
        {
            services.Configure<ConnectioStringOptions>(configuration.GetSection(ConnectioStringOptions.SectionName));
            return services;
        }
    }
}
