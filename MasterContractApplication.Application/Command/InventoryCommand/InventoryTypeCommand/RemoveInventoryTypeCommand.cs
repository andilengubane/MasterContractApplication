using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.InventoryCommand.InventoryTypeCommand
{
    public record RemoveInventoryTypeCommand(Guid Id) : IRequest<bool>;
    public class RemoveInventoryTypeCommandHandler(IInventoryTypeRepository _inventoryTypeRepository) : IRequestHandler<RemoveInventoryTypeCommand, bool>
    {
        public async Task<bool> Handle(RemoveInventoryTypeCommand request, CancellationToken cancellationToken)
        {
            return await _inventoryTypeRepository.RemoveInventoryTypeAsync(request.Id);
        }
    }
}
