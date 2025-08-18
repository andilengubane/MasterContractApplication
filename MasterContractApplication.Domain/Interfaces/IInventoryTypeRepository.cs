using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IInventoryTypeRepository
    {
        Task<IEnumerable<InventoryType>> GetAllInventoryTypeAsync();

        Task<InventoryType> GetInventoryTypeByIdAsync(Guid Id);
    }
}
