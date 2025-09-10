using MasterContractApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IBankDetailsRepository
    {
        Task<IEnumerable<BankDetails>> GetAllBankDetailsAsync();
        Task<BankDetails> GetBankDetailsByIdAsync(Guid Id);
        Task<BankDetails> AddBankDetailsAsync(BankDetails bankDetails);
        Task<bool> RemoveBankDetailsAsync(Guid Id);
        Task<BankDetails> UpdateBankDetailsAsync(Guid Id, BankDetails bankDetails);
    }
}
