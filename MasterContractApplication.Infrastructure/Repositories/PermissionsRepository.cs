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
    }
}
