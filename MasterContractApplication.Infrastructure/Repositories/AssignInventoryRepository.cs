using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
            var inventory = await _masterContractApplicationContext.AssignInventorys.FirstOrDefaultAsync(u => u.Id == Id);

            if (inventory == null)
                throw new KeyNotFoundException($"No assign inventory found with Id: {Id}");

            return inventory;
        }

        public async Task<AssignInventory> AddAssignInventoryAsync(AssignInventory inventoryDetails)
        {
            inventoryDetails.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(inventoryDetails);
            await _masterContractApplicationContext.SaveChangesAsync();
            return inventoryDetails;
        }

        public async Task<bool> RemoveAssignInventoryAsync(Guid Id)
        {
            var removeAssignInventory = await _masterContractApplicationContext.AssignInventorys.SingleOrDefaultAsync(u => u.Id == Id);
            if (removeAssignInventory is not null)
            {
                _masterContractApplicationContext.AssignInventorys.Remove(removeAssignInventory);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<AssignInventory> UpdateassignInventoryAsync(Guid Id, AssignInventory assignInventory)
        {
            var assignInventoryUpddate = await _masterContractApplicationContext.AssignInventorys.SingleOrDefaultAsync(u => u.Id == Id);
            if (assignInventoryUpddate is not null)
            {
                assignInventoryUpddate.CostCenterId = assignInventory.CostCenterId;
                assignInventoryUpddate.InventoryId = assignInventory.InventoryId;
                assignInventoryUpddate.EmployeeId = assignInventory.EmployeeId;
                assignInventoryUpddate.InventoryTypeId = assignInventory.InventoryTypeId;
                assignInventoryUpddate.IsActive = assignInventory.IsActive;
                assignInventoryUpddate.DateLogged = DateTime.Today;

                await _masterContractApplicationContext.SaveChangesAsync();
                return assignInventoryUpddate;
            }
            return assignInventory;
        }
    }
}
