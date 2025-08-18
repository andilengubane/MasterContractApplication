using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;

namespace MasterContractApplication.Application.Queries.PermissionQueries
{
    public record GetPermissionsRepositoryQuery() : IRequest<IEnumerable<Permissions>>;
    internal class GetPermissionsRepositoryQueryHandler(IPermissionsRepository permissionsRepository)
    : IRequestHandler<GetPermissionsRepositoryQuery, IEnumerable<Permissions>>
    {
        public async Task<IEnumerable<Permissions>> Handle(GetPermissionsRepositoryQuery request, CancellationToken cancellationToken)
        {
            return await permissionsRepository.GetAllPermissionsAsync();
        }
    }
}
