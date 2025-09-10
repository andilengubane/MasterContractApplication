using MasterContractApplication.Application.Queries.InventoryQueries.AssignInventoryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MasterContractApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController(ISender sender) : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> GetAllAssignInventoryAsync()
        {
            var result = await sender.Send(new GetAssignInventoryQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllAssignInventoryAsync([FromRoute] Guid id)
        {
            var result = await sender.Send(new GetAssignInventoryByIdQuery(id));
            return Ok(result);
        }
    }
}
