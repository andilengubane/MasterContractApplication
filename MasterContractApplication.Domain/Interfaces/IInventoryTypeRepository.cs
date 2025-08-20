using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IInventoryTypeRepository
    {
        Task<IEnumerable<InventoryType>> GetAllInventoryTypeAsync();
        Task<InventoryType> GetInventoryTypeByIdAsync(Guid Id);
        Task<InventoryType> AddInventoryTypeAsync(InventoryType inventoryType);
        Task<bool> RemoveInventoryTypeAsync(Guid Id);
        Task<InventoryType> UpdateInventoryTypeAsync(Guid Id, InventoryType inventoryType);
    }
}
