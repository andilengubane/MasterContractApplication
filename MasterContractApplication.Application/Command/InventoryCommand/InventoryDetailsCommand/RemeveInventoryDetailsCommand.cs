using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.InventoryCommand.InventoryDetailsCommand
{
    public record RemeveInventoryDetailsCommand(Guid Id) : IRequest<bool>;

    public class RemeveInventoryDetailsCommandHandler(IInventoryDetailsRepository _inventoryDetailsRepository) : IRequestHandler<RemeveInventoryDetailsCommand, bool>
    {
        public async Task<bool> Handle(RemeveInventoryDetailsCommand request, CancellationToken cancellationToken)
        {
            return await _inventoryDetailsRepository.RemoveInventoryDetailsAsync(request.Id);
        }
    }
}
