using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.BankCommand.BanksDetails
{
    public record AddBankDetailsCommand(BankDetails bankDetails) : IRequest<BankDetails>;
    public class AddBankDetailsCommandHandler(IBankDetailsRepository _bankDetailsRepository) : IRequestHandler<AddBankDetailsCommand, BankDetails>
    {
        public async Task<BankDetails> Handle(AddBankDetailsCommand request, CancellationToken cancellationToken)
        {
            var bankDetails = await _bankDetailsRepository.AddBankDetailsAsync(request.bankDetails);
            return bankDetails;
        }
    }
}