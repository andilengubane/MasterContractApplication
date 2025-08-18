using MasterContractApplication.Application.Queries.InventoryQueries.InventoryTypeQueries;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryDetailsQueries
{
    public record GetInventoryDetailsQuery() : IRequest<IEnumerable<InventoryDetails>>;

    internal class GetInventoryDetailsQueryHandler(IInventoryDetailsRepository inventoryDetailsRepository)
     : IRequestHandler<GetInventoryDetailsQuery, IEnumerable<InventoryDetails>>
    {
        public async Task<IEnumerable<InventoryDetails>> Handle(GetInventoryDetailsQuery request, CancellationToken cancellationToken)
        {
            return await inventoryDetailsRepository.GetAllInventoryDetailsAsync();
        }
    }
}
