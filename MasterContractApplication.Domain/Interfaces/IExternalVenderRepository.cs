using MasterContractApplication.Domain.DTO;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IExternalVenderRepository
    {
        Task<ExternalVenderDto> GetData();
    }
}
