using Microsoft.EntityFrameworkCore;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class RoleRepository(MasterContractApplicationContext _masterContractApplicationContext) : IRoleRepository
    {
        public async Task<IEnumerable<Role>> GetAllRoleAsync()
        {
            return await _masterContractApplicationContext.Roles.ToListAsync();
        }

        public async Task<Role> GetRoleByIdAsync(Guid Id)
        {
            var role = await _masterContractApplicationContext.Roles.FirstOrDefaultAsync(u => u.Id == Id);

            if (role == null)
                throw new KeyNotFoundException($"No role found with Id: {Id}");

            return role;
        }

        public async Task<Role> AddRoleAsync(Role role)
        {
            role.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(role);
            await _masterContractApplicationContext.SaveChangesAsync();
            return role;
        }

        public async Task<bool> RemoveRoleAsync(Guid Id)
        {
            var removeRole = await _masterContractApplicationContext.Roles.SingleOrDefaultAsync(u => u.Id == Id);
            if (removeRole is not null)
            {
                _masterContractApplicationContext.Roles.Remove(removeRole);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
