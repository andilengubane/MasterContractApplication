using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IInventoryDetailsRepository
    {
        Task<IEnumerable<InventoryDetails>> GetAllInventoryDetailsAsync();

        Task<InventoryDetails> GetInventoryDetailsByIdAsync(Guid Id);
    }
}
