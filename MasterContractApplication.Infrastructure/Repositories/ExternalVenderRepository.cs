using MasterContractApplication.Infrastructure.Services;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class ExternalVenderRepository(ContextHttpClientService httpClient) 
    {
        public async Task<dynamic> GetSourceData()
        {
            return await httpClient.GetData();
        }
    }
}
