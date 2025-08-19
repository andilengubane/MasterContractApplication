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
            var inventoryTypes = await _masterContractApplicationContext.InventoryTypes.FirstOrDefaultAsync(u => u.Id == Id);

            if (inventoryTypes == null)
                throw new KeyNotFoundException($"No inventory types found with Id: {Id}");

            return inventoryTypes;
        }

        public async Task<InventoryType> AddInventoryTypeAsync(InventoryType inventoryType)
        {
            inventoryType.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(inventoryType);
            await _masterContractApplicationContext.SaveChangesAsync();
            return inventoryType;
        }

        public async Task<bool> RemoveInventoryTypeAsync(Guid Id)
        {
            var removeInventoryType = await _masterContractApplicationContext.InventoryTypes.SingleOrDefaultAsync(u => u.Id == Id);
            if (removeInventoryType is not null)
            {
                _masterContractApplicationContext.InventoryTypes.Remove(removeInventoryType);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}