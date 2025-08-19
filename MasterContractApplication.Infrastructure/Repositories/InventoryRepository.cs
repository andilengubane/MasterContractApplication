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
            var inventoryDetails = await _masterContractApplicationContext.Inventorys.FirstOrDefaultAsync(u => u.Id == Id);

            if (inventoryDetails == null)
                throw new KeyNotFoundException($"No inventory found with Id: {Id}");

            return inventoryDetails;

        }

        public async Task<Inventory> AddInventoryAsync(Inventory inventory)
        {
            inventory.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(inventory);
            await _masterContractApplicationContext.SaveChangesAsync();
            return inventory;
        }

        public async Task<bool> RemoveInventoryAsync(Guid Id)
        {
            var removeInventory = await _masterContractApplicationContext.Inventorys.SingleOrDefaultAsync(u => u.Id == Id);
            if (removeInventory is not null)
            {
                _masterContractApplicationContext.Inventorys.Remove(removeInventory);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}