using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class InventoryDetailsRepository(MasterContractApplicationContext _masterContractApplicationContext) : IInventoryDetailsRepository
    {
        public async Task<IEnumerable<InventoryDetails>> GetAllInventoryDetailsAsync()
        {
            return await _masterContractApplicationContext.InventoryDetails.ToListAsync();
        }
    }
}
