using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.PermissionCommand
{
    public record RemovePermissionsCommand(Guid id) : IRequest<bool>;

    public class RemovePermissionsCommandHandler(IPermissionsRepository _permissionsRepository) : IRequestHandler<RemovePermissionsCommand, bool>
    {
        public Task<bool> Handle(RemovePermissionsCommand request, CancellationToken cancellationToken)
        {
            return _permissionsRepository.RemovePermissionsAsync(request.id);
        }
    }
}
