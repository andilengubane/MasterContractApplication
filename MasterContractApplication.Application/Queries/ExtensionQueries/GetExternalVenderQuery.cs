using MasterContractApplication.Domain.DTO;
using MasterContractApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Queries.ExtensionQueries
{
    public record GetExternalVenderQuery() : IRequest<ExternalVenderDto>;

    internal class GetExternalVenderQueryHanlder(IExternalVenderRepository externalVenderRepository) : IRequestHandler<GetExternalVenderQuery, ExternalVenderDto>
    {
        public async Task<ExternalVenderDto> Handle(GetExternalVenderQuery request, CancellationToken cancellationToken)
        {
            return await externalVenderRepository.GetData();
        }
    }
}
