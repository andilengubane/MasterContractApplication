using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.InventoryCommand.AssignInventoryCommand
{
    public record AddAssignInventoryCommand(AssignInventory assignInventory) : IRequest<AssignInventory>;
    public class AddInventoryDetailsCommandHandler(IAssignInventoryRepository _assignInventoryRepository) : IRequestHandler<AddAssignInventoryCommand, AssignInventory>
    {
        public async Task<AssignInventory> Handle(AddAssignInventoryCommand request, CancellationToken cancellationToken)
        {
            var assignInventory = await _assignInventoryRepository.AddAssignInventoryAsync(request.assignInventory);
            return assignInventory;
        }
    }
}
