using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.BankCommand.BankAccountDetails
{
    public record RemoveBankAccountDetails(Guid Id) : IRequest<bool>;
    public class RemoveBankAccountDetailsHandler(IBankDetailsRepository _bankDetailsRepository) : IRequestHandler<RemoveBankAccountDetails, bool>
    {
        public async Task<bool> Handle(RemoveBankAccountDetails request, CancellationToken cancellationToken)
        {
            return await _bankDetailsRepository.RemoveBankDetailsAsync(request.Id);
        }
    }
}