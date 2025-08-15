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
    }
}
