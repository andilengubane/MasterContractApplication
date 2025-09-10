using MasterContractApplication.Domain.DTO;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Services.Interface;
using System.Net.Http.Json;

namespace MasterContractApplication.Infrastructure.Services
{
    public class ContextHttpClientService(HttpClient httpClient): IExternalVenderRepository, IContextHttpClientService
    {
        public async Task<ExternalVenderDto> GetData()
        {
            return await httpClient.GetFromJsonAsync<ExternalVenderDto>("api/ExternalVender");
        }
    }
}
