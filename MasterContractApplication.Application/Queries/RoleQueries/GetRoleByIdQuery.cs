using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.RoleQueries
{
    public record GetRoleByIdQuery(Guid id) : IRequest<Role>;

    public class GetRoleByIdQueryHandle(IRoleRepository _roleRepository) : IRequestHandler<GetRoleByIdQuery, Role>
    {
        public async Task<Role> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            return await _roleRepository.GetRoleByIdAsync(request.id);
        }
    }
}