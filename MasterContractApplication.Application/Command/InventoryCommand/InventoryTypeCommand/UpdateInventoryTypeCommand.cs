using MediatR;
using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Application.Command.InventoryCommand.InventoryTypeCommand
{
    public record UpdateInventoryTypeCommand(Guid Id, InventoryType inventoryType) : IRequest<InventoryType>;
   
}
