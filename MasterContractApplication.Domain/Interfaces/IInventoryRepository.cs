using MasterContractApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetAllInventoryAsync();

        Task<Inventory> GetInventoryByIdAsync(Guid Id);
    }
}
