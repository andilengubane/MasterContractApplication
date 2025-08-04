using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.Roles
{
    public record GetRoleByIdQuery(Guid id): IRequest<Role>;

    internal class GetRoleByIdQueryHandle(IRoleRepository roleRepository) : IRequestHandler<GetRoleByIdQuery, Role>
    {
        public async Task<Role> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            return await roleRepository.GetRoleByIdAsync(request.id);
        }
    }
}