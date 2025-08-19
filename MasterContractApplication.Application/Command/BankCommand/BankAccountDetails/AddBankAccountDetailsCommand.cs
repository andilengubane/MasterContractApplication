using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.BankCommand.BankAccountDetails
{
    public record AddBankAccountDetailsCommand(BankAccount bankAccount) : IRequest<BankAccount>;
    public class AddBankAccountDetailsCommandHandler(IBankAccountRepository _bankAccountRepository) : IRequestHandler<AddBankAccountDetailsCommand, BankAccount>
    {
        public async Task<BankAccount> Handle(AddBankAccountDetailsCommand request, CancellationToken cancellationToken)
        {
            var bankAccount = await _bankAccountRepository.AddBankAccountsAsync(request.bankAccount);
            return bankAccount;
        }
    }
}
