using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.InventoryCommand.AssignInventoryCommand
{
    public record RemoveAssignInventoryCommand(Guid Id) : IRequest<bool>;
    public class RemoveAssignInventoryCommandHandler(IAssignInventoryRepository _assignInventoryRepository) : IRequestHandler<RemoveAssignInventoryCommand, bool>
    {
        public async Task<bool> Handle(RemoveAssignInventoryCommand request, CancellationToken cancellationToken)
        {
            return await _assignInventoryRepository.RemoveAssignInventoryAsync(request.Id);
        }
    }
}