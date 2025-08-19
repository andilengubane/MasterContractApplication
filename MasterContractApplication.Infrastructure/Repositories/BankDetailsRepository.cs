using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class BankDetailsRepository(MasterContractApplicationContext _masterContractApplicationContext) : IBankDetailsRepository
    {
        public async Task<IEnumerable<BankDetails>> GetAllBankDetailsAsync()
        {
            return await _masterContractApplicationContext.BankDetails.ToListAsync();
        }

        public async Task<BankDetails> GetInventoryDetailsByIdAsync(Guid Id)
        {
            var bankDetails = await _masterContractApplicationContext.BankDetails.FirstOrDefaultAsync(u => u.Id == Id);

            if (bankDetails == null)
                throw new KeyNotFoundException($"No bank details found with Id: {Id}");

            return bankDetails;
        }

        public async Task<BankDetails> AddBankDetailsAsync(BankDetails bankDetails)
        {
            bankDetails.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(bankDetails);
            await _masterContractApplicationContext.SaveChangesAsync();
            return bankDetails;
        }

        public async Task<bool> RemoveInventoryTypeAsync(Guid Id)
        {
            var bankDetails = await _masterContractApplicationContext.BankDetails.SingleOrDefaultAsync(u => u.Id == Id);
            if (bankDetails is not null)
            {
                _masterContractApplicationContext.BankDetails.Remove(bankDetails);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
