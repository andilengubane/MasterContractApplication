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
    }
}
