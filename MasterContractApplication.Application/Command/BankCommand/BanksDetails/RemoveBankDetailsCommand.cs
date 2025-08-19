using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.BankCommand.BanksDetails
{
    public record RemoveBankDetailsCommand(Guid Id) : IRequest<bool>;
    public class RemoveBankDetailsCommandHandler(IBankDetailsRepository _bankDetailsRepository) : IRequestHandler<RemoveBankDetailsCommand, bool>
    {
        public async Task<bool> Handle(RemoveBankDetailsCommand request, CancellationToken cancellationToken)
        {
            return await _bankDetailsRepository.RemoveInventoryTypeAsync(request.Id);
        }
    }
}
