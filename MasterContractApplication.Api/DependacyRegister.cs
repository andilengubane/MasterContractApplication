using MasterContractApplication.Application;
using MasterContractApplication.Infrastructure;

namespace MasterContractApplication.Api
{
    public static class DependacyRegister
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services.AddApplicationDI()
                    .AddInfastractureDI();

            return services;
        }
    }
}
