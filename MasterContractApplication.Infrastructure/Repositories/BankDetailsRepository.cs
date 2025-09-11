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

        public async Task<BankDetails> GetBankDetailsByIdAsync(Guid Id)
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

        public async Task<bool> RemoveBankDetailsAsync(Guid Id)
        {
            var bankDetails = await _masterContractApplicationContext.BankDetails.SingleOrDefaultAsync(u => u.Id == Id);
            if (bankDetails is not null)
            {
                _masterContractApplicationContext.BankDetails.Remove(bankDetails);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
        public async Task<BankDetails> UpdateBankDetailsAsync(Guid Id, BankDetails bankDetails)
        {
            var bankDetailsUpdate = await _masterContractApplicationContext.BankDetails.SingleOrDefaultAsync(u => u.Id == Id);
            if (bankDetailsUpdate is not null)
            {
                bankDetailsUpdate.BankName = bankDetails.BankName;
                bankDetailsUpdate.BranchCode = bankDetails.BranchCode;
                bankDetailsUpdate.IsActive = bankDetails.IsActive;
                bankDetailsUpdate.Batch = bankDetails.Batch;
                bankDetailsUpdate.BranchCode = bankDetails.BranchCode;
                bankDetailsUpdate.BranchCode = bankDetails.BranchCode;
                bankDetailsUpdate.CreatedDate = DateTime.Today;
                bankDetailsUpdate.ModifyDate = bankDetails.ModifyDate;

                await _masterContractApplicationContext.SaveChangesAsync();

                return bankDetailsUpdate;
            }
            return bankDetails;
        }
    }
}
