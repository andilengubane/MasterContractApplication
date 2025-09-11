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
        public async Task<Inventory> UpdateInventoryAsync(Guid Id, Inventory inventory)
        {
            var inventoryUpdate = await _masterContractApplicationContext.Inventorys.SingleOrDefaultAsync(u => u.Id == Id);
            if (inventoryUpdate is not null)
            {
                inventoryUpdate.InventoryTypeId = inventory.InventoryTypeId;
                inventoryUpdate.InventoryDetailId = inventory.InventoryDetailId;
                inventoryUpdate.IsActive = inventory.IsActive;
                inventoryUpdate.OrderDate = DateTime.Today;
                inventoryUpdate.ExpireDate = DateTime.Today;
                inventoryUpdate.CreateDate = DateTime.Today;

                await _masterContractApplicationContext.SaveChangesAsync();

                return inventoryUpdate;
            }
            return inventory;
        }
    }
}