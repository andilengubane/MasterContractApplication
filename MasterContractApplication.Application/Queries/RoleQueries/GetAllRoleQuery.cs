using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.RoleQueries
{
    public record GetAllRoleQuery() : IRequest<IEnumerable<Role>>;

    public class GetAllRoleQueryHandler(IRoleRepository _roleRepository) : IRequestHandler<GetAllRoleQuery, IEnumerable<Role>>
    {
        public async Task<IEnumerable<Role>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            return await _roleRepository.GetAllRoleAsync();
        }
    }
}