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
    public record GetInventoryDetailsByIdQuery(Guid Id) : IRequest<InventoryDetails>;

    internal class GetInventoryTypeByIdQueryHandler(IInventoryDetailsRepository inventoryDetailsRepository) : IRequestHandler<GetInventoryDetailsByIdQuery, InventoryDetails>
    {
        public async Task<InventoryDetails> Handle(GetInventoryDetailsByIdQuery request, CancellationToken cancellationToken)
        {
            return await inventoryDetailsRepository.GetInventoryDetailsByIdAsync(request.Id);
        }
    }
}
