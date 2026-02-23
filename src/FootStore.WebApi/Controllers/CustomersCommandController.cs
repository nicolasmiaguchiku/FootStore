using FootStore.Application.Input.Commands;
using FootStore.Application.Requests;
using LiteBus.Commands.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FootStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/Customers")]
    public class CustomersCommandController(ICommandMediator commandMediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCustomerAsync([FromBody] AddCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = await commandMediator.SendAsync(new AddCustomerCommand(request), cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);

            }
            return Ok(result);
        }
    }
}