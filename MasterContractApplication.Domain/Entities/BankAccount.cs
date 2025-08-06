using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.Entities
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public string AccountReference { get; set; } = string.Empty;
        public string AVSNumber { get; set; } = string.Empty;
        public string IdNumber { get; set; } = string.Empty;
        public string BankAccountDetails { get; set; } = string.Empty;
        public string BankAccountName { get; set; } = string.Empty;
        public string BankAccountType { get; set; } = string.Empty;
        public string BranchCode { get; set; } = string.Empty;
        public string BankAccountNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
