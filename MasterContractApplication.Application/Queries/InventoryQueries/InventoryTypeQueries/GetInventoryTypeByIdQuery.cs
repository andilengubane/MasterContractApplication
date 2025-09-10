using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryTypeQueries
{
    public record class GetInventoryTypeByIdQuery(Guid Id) : IRequest<InventoryType>;

    public class GetInventoryTypeByIdQueryHandler(IInventoryTypeRepository _inventoryTypeRepository) : IRequestHandler<GetInventoryTypeByIdQuery, InventoryType>
    {
        public async Task<InventoryType> Handle(GetInventoryTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _inventoryTypeRepository.GetInventoryTypeByIdAsync(request.Id);
        }
    }
}