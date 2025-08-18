using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryTypeQueries
{
    public record GetInventoryTypeQuery() : IRequest<IEnumerable<InventoryType>>;

    internal class GetInventoryTypeQueryHandler(IInventoryTypeRepository inventoryTypeRepository)
     : IRequestHandler<GetInventoryTypeQuery, IEnumerable<InventoryType>>
    {
        public async Task<IEnumerable<InventoryType>> Handle(GetInventoryTypeQuery request, CancellationToken cancellationToken)
        {
            return await inventoryTypeRepository.GetAllInventoryTypeAsync();
        }
    }
}
