using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IAssignInventoryRepository
    {
        Task<IEnumerable<AssignInventory>> GetAllAssignInventoryAsync();

        Task<AssignInventory> GetAssignInventoryByIdAsync(Guid Id);
    }
}
