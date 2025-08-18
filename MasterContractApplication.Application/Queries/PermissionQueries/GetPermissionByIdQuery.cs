using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Queries.PermissionQueries
{
    public record class GetPermissionByIdQuery(Guid Id) : IRequest<Permissions>;

    internal class GetPermissionByIdQueryHandler(IPermissionsRepository permissionsRepository) : IRequestHandler<GetPermissionByIdQuery, Permissions>
    {
        public async Task<Permissions> Handle(GetPermissionByIdQuery request, CancellationToken cancellationToken)
        {
            return await permissionsRepository.GetPermissionsByIdAsync(request.Id);
        }
    }
}
