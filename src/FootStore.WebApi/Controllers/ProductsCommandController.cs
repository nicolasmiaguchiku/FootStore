using FootStore.Application.Input.Commands;
using FootStore.Application.Requests;
using LiteBus.Commands.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FootStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/Products")]
    public class ProductsCommandController(ICommandMediator commandMediator) : ControllerBase
    {
        /// <summary>
        ///     Add new product to the store
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddProductAsync([FromBody] AddProductRequest request, CancellationToken cancellationToken)
        {
            var result = await commandMediator.SendAsync(new AddProductCommand(request), cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.IsSuccess);
        }
    }
}