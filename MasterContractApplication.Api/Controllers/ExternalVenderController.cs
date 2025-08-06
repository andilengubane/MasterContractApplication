using MediatR;
using Microsoft.AspNetCore.Mvc;
using MasterContractApplication.Application.Queries.ExtensionQueries;

namespace MasterContractApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVenderController(ISender sender) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDate()
        {
            var result = await sender.Send(new GetExternalVenderQuery());
            return Ok(result);
        }
    }
}
