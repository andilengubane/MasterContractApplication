using MasterContractApplication.Application;
using MasterContractApplication.Domain;
using MasterContractApplication.Infrastructure;

namespace MasterContractApplication.Api
{
    public static class DependacyRegister
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                    .AddInfastractureDI()
                    .AddDomainID(configuration);

            return services;
        }
    }
}
