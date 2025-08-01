using MasterContractApplication.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class ExternalVenderRepository(ContextHttpClientService httpClient)
    {
        public async Task<dynamic> GetSourceData()
        {
            return await await httpClient.GetData();
        }
    }
}
