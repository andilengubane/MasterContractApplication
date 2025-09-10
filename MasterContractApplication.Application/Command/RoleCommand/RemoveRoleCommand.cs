using MediatR;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.RoleCommand
{
    public record RemoveRoleCommand(Guid id) : IRequest<bool>;

    public class RemoveRoleCommandHandler(IRoleRepository _roleRepository) : IRequestHandler<RemoveRoleCommand, bool>
    {
        public Task<bool> Handle(RemoveRoleCommand request, CancellationToken cancellationToken)
        {
            return _roleRepository.RemoveRoleAsync(request.id);
        }
    }
}