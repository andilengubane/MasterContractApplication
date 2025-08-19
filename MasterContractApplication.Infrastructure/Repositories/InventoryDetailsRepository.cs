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

        public async Task<InventoryDetails> GetInventoryDetailsByIdAsync(Guid Id)
        {
            var inventoryDetails = await _masterContractApplicationContext.InventoryDetails.FirstOrDefaultAsync(u => u.Id == Id);

            if (inventoryDetails == null)
                throw new KeyNotFoundException($"No inventory details found with Id: {Id}");

            return inventoryDetails;
        }

        public async Task<InventoryDetails> AddInventoryTypeAsync(InventoryDetails inventoryDetails)
        {
            inventoryDetails.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(inventoryDetails);
            await _masterContractApplicationContext.SaveChangesAsync();
            return inventoryDetails;
        }

        public async Task<bool> RemoveInventoryTypeAsync(Guid Id)
        {
            var removeInventoryDetails = await _masterContractApplicationContext.InventoryDetails.SingleOrDefaultAsync(u => u.Id == Id);
            if (removeInventoryDetails is not null)
            {
                _masterContractApplicationContext.InventoryDetails.Remove(removeInventoryDetails);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
