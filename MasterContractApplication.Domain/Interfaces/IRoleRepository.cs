using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetAllRoleAsync();
        Task<Role> GetRoleByIdAsync(Guid Id);
        Task<Role> AddRoleAsync(Role role);
        Task<bool> RemoveRoleAsync(Guid Id);
    }
}
