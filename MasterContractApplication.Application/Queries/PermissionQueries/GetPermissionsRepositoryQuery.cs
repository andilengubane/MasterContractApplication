using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.PermissionQueries
{
    public record GetPermissionsRepositoryQuery() : IRequest<IEnumerable<Permissions>>;
    public class GetPermissionsRepositoryQueryHandler(IPermissionsRepository _permissionsRepository): IRequestHandler<GetPermissionsRepositoryQuery, IEnumerable<Permissions>>
    {
        public async Task<IEnumerable<Permissions>> Handle(GetPermissionsRepositoryQuery request, CancellationToken cancellationToken)
        {
            return await _permissionsRepository.GetAllPermissionsAsync();
        }
    }
}
