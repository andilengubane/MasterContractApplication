using MasterContractApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<IEnumerable<BankAccount>> GetAllBankAccountAsync();
        Task<BankAccount> GetBankAccountByIdAsync(Guid Id);
        Task<BankAccount> AddBankAccountsAsync(BankAccount bankAccount);
        Task<bool> RemoveBankAccountsAsync(Guid Id);
        Task<BankAccount> UpdateBankAccountAsync(Guid Id, BankAccount bankAccount);
    }
}
