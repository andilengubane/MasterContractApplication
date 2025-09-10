using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.PermissionCommand
{
    public record AddPermissionCommand(Permissions permissions) : IRequest<Permissions>;

    public class AddPermissionCommandHandler(IPermissionsRepository _permissionsRepository): IRequestHandler<AddPermissionCommand, Permissions>
    {
        public async Task<Permissions> Handle(AddPermissionCommand request, CancellationToken cancellationToken)
        {
            var permissions = await _permissionsRepository.AddPermissionsAsync(request.permissions);
            return permissions;
        }
    }
}
