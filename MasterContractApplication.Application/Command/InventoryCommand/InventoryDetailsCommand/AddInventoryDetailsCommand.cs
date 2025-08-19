using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.InventoryCommand.InventoryDetailsCommand
{
    public record AddInventoryDetailsCommand(InventoryDetails inventoryDetails) : IRequest<InventoryDetails>;

    public class AddInventoryDetailsCommandHandler(IInventoryDetailsRepository _inventoryDetailsRepository) : IRequestHandler<AddInventoryDetailsCommand, InventoryDetails>
    {
        public async Task<InventoryDetails> Handle(AddInventoryDetailsCommand request, CancellationToken cancellationToken)
        {
            var inventoryType = await _inventoryDetailsRepository.AddInventoryDetailsAsync(request.inventoryDetails);
            return inventoryType;
        }
    }
}