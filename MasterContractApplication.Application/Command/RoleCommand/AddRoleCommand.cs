using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;


namespace MasterContractApplication.Application.Command.RoleCommand
{
    public record AddRoleCommand(Role role) : IRequest<Role>;

    public class AddRoleCommandHandler(IRoleRepository _roleRepository) : IRequestHandler<AddRoleCommand, Role>
    {
        public async Task<Role> Handle(AddRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _roleRepository.AddRoleAsync(request.role);
            return role;
        }
    }
}
