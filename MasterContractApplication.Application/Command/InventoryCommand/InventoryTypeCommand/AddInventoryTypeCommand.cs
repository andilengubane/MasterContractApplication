using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.InventoryCommand.InventoryTypeCommand
{
    public record AddInventoryTypeCommand(InventoryType inventoryType) : IRequest<InventoryType>;

    public class AddInventoryTypeCommandHandler(IInventoryTypeRepository _inventoryTypeRepository) : IRequestHandler<AddInventoryTypeCommand, InventoryType>
    {
        public async Task<InventoryType> Handle(AddInventoryTypeCommand request, CancellationToken cancellationToken)
        {
            var inventoryType = await _inventoryTypeRepository.AddInventoryTypeAsync(request.inventoryType);
            return inventoryType;
        }
    }
}
