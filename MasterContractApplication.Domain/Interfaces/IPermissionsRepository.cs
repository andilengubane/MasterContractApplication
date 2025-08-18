using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IPermissionsRepository
    {
        Task<IEnumerable<Permissions>> GetAllPermissionsAsync();

        Task<Permissions> GetPermissionsByIdAsync(Guid Id);
    }
}
