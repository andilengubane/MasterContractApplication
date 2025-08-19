using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class PermissionsRepository(MasterContractApplicationContext _masterContractApplicationContext): IPermissionsRepository
    {
        public async Task<IEnumerable<Permissions>> GetAllPermissionsAsync()
        {
            return await _masterContractApplicationContext.Permissions.ToListAsync();
        }

        public async Task<Permissions> GetPermissionsByIdAsync(Guid Id)
        {
            var permissions = await _masterContractApplicationContext.Permissions.FirstOrDefaultAsync(u => u.Id == Id);

            if (permissions == null)
                throw new KeyNotFoundException($"No permissions found with Id: {Id}");

            return permissions;
        }

        public async Task<Permissions> AddPermissionsAsync(Permissions permissions)
        {
            permissions.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(permissions);
            await _masterContractApplicationContext.SaveChangesAsync();
            return permissions;
        }

        public async Task<Permissions> UpdatePermissionsAsync(Guid Id, Permissions permissions)
        {
            var permissionsUpdate = await _masterContractApplicationContext.Permissions.SingleOrDefaultAsync(u => u.Id == Id);
            if (permissionsUpdate is not null)
            {
                permissionsUpdate.Description = permissions.Description;
                permissionsUpdate.IsActive = permissions.IsActive;
                permissionsUpdate.Name = permissions.Name;
                permissionsUpdate.Createddate = DateTime.Today;

                await _masterContractApplicationContext.SaveChangesAsync();

                return permissionsUpdate;
            }
            return permissions;
        }

        public async Task<bool> RemovePermissionsAsync(Guid Id)
        {
            var removePermissions = await _masterContractApplicationContext.Permissions.SingleOrDefaultAsync(u => u.Id == Id);
            if (removePermissions is not null)
            {
                _masterContractApplicationContext.Permissions.Remove(removePermissions);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
