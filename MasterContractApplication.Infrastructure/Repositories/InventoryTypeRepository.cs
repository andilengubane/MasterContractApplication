using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class InventoryTypeRepository(MasterContractApplicationContext _masterContractApplicationContext) : IInventoryTypeRepository
    {
        public async Task<IEnumerable<InventoryType>> GetAllInventoryTypeAsync()
        {
            return await _masterContractApplicationContext.InventoryTypes.ToListAsync();
        }

        public async Task<InventoryType> GetInventoryTypeByIdAsync(Guid Id)
        {
            return await _masterContractApplicationContext.InventoryTypes.FirstOrDefaultAsync(u => u.Id == Id);
        }
    }
}
