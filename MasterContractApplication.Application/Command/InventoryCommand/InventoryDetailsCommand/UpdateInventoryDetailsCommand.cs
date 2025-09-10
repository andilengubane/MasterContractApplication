using MasterContractApplication.Domain.Entities;
using MediatR;

namespace MasterContractApplication.Application.Command.InventoryCommand.InventoryDetailsCommand
{
    public record UpdateInventoryDetailsCommand() : IRequest<InventoryDetails>;
}
