
using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.InventoryQueries.InventoryDetailsQueries
{
    public record GetInventoryDetailsByIdQuery(Guid Id) : IRequest<InventoryDetails>;

    public class GetInventoryTypeByIdQueryHandler(IInventoryDetailsRepository _inventoryDetailsRepository) : IRequestHandler<GetInventoryDetailsByIdQuery, InventoryDetails>
    {
        public async Task<InventoryDetails> Handle(GetInventoryDetailsByIdQuery request, CancellationToken cancellationToken)
        {
            return await _inventoryDetailsRepository.GetInventoryDetailsByIdAsync(request.Id);
        }
    }
}
