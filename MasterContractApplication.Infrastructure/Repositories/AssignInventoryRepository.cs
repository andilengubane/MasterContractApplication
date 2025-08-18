using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class AssignInventoryRepository(MasterContractApplicationContext _masterContractApplicationContext) : IAssignInventoryRepository
    {
        public async Task<IEnumerable<AssignInventory>> GetAllAssignInventoryAsync()
        {
            return await _masterContractApplicationContext.AssignInventorys.ToListAsync();
        }

        public async Task<AssignInventory> GetAssignInventoryByIdAsync(Guid Id)
        {
            return await _masterContractApplicationContext.AssignInventorys.FirstOrDefaultAsync(u => u.Id == Id);
        }
        
    }
}
