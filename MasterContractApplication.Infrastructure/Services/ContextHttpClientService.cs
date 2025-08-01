using MasterContractApplication.Domain.Interfaces;
using System.Net.Http.Json;

namespace MasterContractApplication.Infrastructure.Services
{
    public class ContextHttpClientService(HttpClient httpClient): IExternalVenderRepository
    {
        public async Task<dynamic> GetData()
        {
            return await httpClient.GetFromJsonAsync<dynamic>("end point");
        }
    }
}
