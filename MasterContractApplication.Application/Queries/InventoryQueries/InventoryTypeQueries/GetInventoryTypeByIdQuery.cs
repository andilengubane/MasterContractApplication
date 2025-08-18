using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryTypeQueries
{

    public record class GetInventoryTypeByIdQuery(Guid Id) : IRequest<InventoryType>;

    internal class GetInventoryTypeByIdQueryHandler(IInventoryTypeRepository inventoryTypeRepository) : IRequestHandler<GetInventoryTypeByIdQuery, InventoryType>
    {
        public async Task<InventoryType> Handle(GetInventoryTypeByIdQuery request, CancellationToken cancellationToken)
        {
            return await inventoryTypeRepository.GetInventoryTypeByIdAsync(request.Id);
        }
    }
}