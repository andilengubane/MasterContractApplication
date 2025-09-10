using MasterContractApplication.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Infrastructure.Services.Interface
{
    public interface IContextHttpClientService
    {
        Task<ExternalVenderDto> GetData();
    }
}
