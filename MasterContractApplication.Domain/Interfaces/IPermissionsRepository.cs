using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IPermissionsRepository
    {
        Task<IEnumerable<Permissions>> GetAllPermissionsAsync();

        Task<Permissions> GetPermissionsByIdAsync(Guid Id);

        Task<Permissions> AddPermissionsAsync(Permissions permissions);

        Task<Permissions> UpdatePermissionsAsync(Guid Id, Permissions permissions);

        Task<bool> RemovePermissionsAsync(Guid Id);
    }
}