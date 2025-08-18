using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class InventoryRepository(MasterContractApplicationContext _masterContractApplicationContext) : IInventoryRepository
    {
        public async Task<IEnumerable<Inventory>> GetAllInventoryAsync()
        {
            return await _masterContractApplicationContext.Inventorys.ToListAsync();
        }

        public async Task<Inventory> GetInventoryByIdAsync(Guid Id)
        {
            return await _masterContractApplicationContext.Inventorys.FirstOrDefaultAsync(u => u.Id == Id);
        }
    }
}
