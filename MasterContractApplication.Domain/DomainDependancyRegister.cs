using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain
{
    public static class DomainDependancyRegister
    {
        public static IServiceCollection AddDomainID(this IServiceCollection services) 
        {
            return services;
        }
    }
}
