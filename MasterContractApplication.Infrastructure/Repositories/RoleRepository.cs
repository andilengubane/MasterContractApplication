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
            return await _masterContractApplicationContext.Roles.FirstOrDefaultAsync(u => u.Id == Id);
        }

        public async Task<Role> AddRoleAsync(Role role)
        {
            role.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(role);
            await _masterContractApplicationContext.SaveChangesAsync();
            return role;
        }
    }
}
