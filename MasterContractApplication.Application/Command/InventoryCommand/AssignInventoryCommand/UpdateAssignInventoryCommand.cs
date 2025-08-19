using MediatR;
using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Application.Command.InventoryCommand.AssignInventoryCommand
{
    public record UpdateAssignInventoryCommand() : IRequest<AssignInventory>;
}