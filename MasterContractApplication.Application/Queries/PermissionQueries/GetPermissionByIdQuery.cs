using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.PermissionQueries
{
    public record class GetPermissionByIdQuery(Guid Id) : IRequest<Permissions>;

    public class GetPermissionByIdQueryHandler(IPermissionsRepository _permissionsRepository) : IRequestHandler<GetPermissionByIdQuery, Permissions>
    {
        public async Task<Permissions> Handle(GetPermissionByIdQuery request, CancellationToken cancellationToken)
        {
            return await _permissionsRepository.GetPermissionsByIdAsync(request.Id);
        }
    }
}
