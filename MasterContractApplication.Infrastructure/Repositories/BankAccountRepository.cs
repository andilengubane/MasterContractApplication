using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class BankAccountRepository(MasterContractApplicationContext _masterContractApplicationContext) : IBankAccountRepository
    {
        public async Task<IEnumerable<BankAccount>> GetAllBankAccountAsync()
        {
            return await _masterContractApplicationContext.BankAccounts.ToListAsync();
        }

        public async Task<BankAccount> GetBankAccountByIdAsync(Guid Id)
        {
            var bankAccounts = await _masterContractApplicationContext.BankAccounts.FirstOrDefaultAsync(u => u.Id == Id);

            if (bankAccounts == null)
                throw new KeyNotFoundException($"No bank account details found with Id: {Id}");

            return bankAccounts;
        }

        public async Task<BankAccount> AddBankAccountsAsync(BankAccount bankAccount)
        {
            bankAccount.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(bankAccount);
            await _masterContractApplicationContext.SaveChangesAsync();
            return bankAccount;
        }

        public async Task<bool> RemoveBankAccountsAsync(Guid Id)
        {
            var removeBankAccounts = await _masterContractApplicationContext.BankAccounts.SingleOrDefaultAsync(u => u.Id == Id);
            if (removeBankAccounts is not null)
            {
                _masterContractApplicationContext.BankAccounts.Remove(removeBankAccounts);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
