using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.Roles
{
    public record AddRoleCommand(Role rope): IRequest<Role>;

    public class AddRoleCommandHandler(IRoleRepository roleRepository) : IRequestHandler<AddRoleCommand, Role>
    {
        public async Task<Role> Handle(AddRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await roleRepository.AddRoleAsync(request.rope);
            return role;
        }
    }
}
