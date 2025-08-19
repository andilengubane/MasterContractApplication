using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryTypeQueries
{
    public record GetInventoryTypeQuery() : IRequest<IEnumerable<InventoryType>>;

    public class GetInventoryTypeQueryHandler(IInventoryTypeRepository _inventoryTypeRepository): IRequestHandler<GetInventoryTypeQuery, IEnumerable<InventoryType>>
    {
        public async Task<IEnumerable<InventoryType>> Handle(GetInventoryTypeQuery request, CancellationToken cancellationToken)
        {
            return await _inventoryTypeRepository.GetAllInventoryTypeAsync();
        }
    }
}
