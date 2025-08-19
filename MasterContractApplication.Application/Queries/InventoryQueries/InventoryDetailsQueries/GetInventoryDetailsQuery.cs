using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryDetailsQueries
{
    public record GetInventoryDetailsQuery() : IRequest<IEnumerable<InventoryDetails>>;

    public class GetInventoryDetailsQueryHandler(IInventoryDetailsRepository _inventoryDetailsRepository): IRequestHandler<GetInventoryDetailsQuery, IEnumerable<InventoryDetails>>
    {
        public async Task<IEnumerable<InventoryDetails>> Handle(GetInventoryDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _inventoryDetailsRepository.GetAllInventoryDetailsAsync();
        }
    }
}
