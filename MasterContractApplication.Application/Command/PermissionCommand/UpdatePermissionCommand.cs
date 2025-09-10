using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.PermissionCommand
{
    public record UpdatePermissionCommand(Guid id, Permissions permissions) : IRequest<Permissions>;

    public class UpdatePermissionCommandHandler(IPermissionsRepository _permissionsRepository) : IRequestHandler<UpdatePermissionCommand, Permissions>
    {
        public async Task<Permissions> Handle(UpdatePermissionCommand request, CancellationToken cancellationToken)
        {
            return await _permissionsRepository.UpdatePermissionsAsync(request.id, request.permissions);
        }
    }
}
