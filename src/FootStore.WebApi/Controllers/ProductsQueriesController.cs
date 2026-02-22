using FootStore.Application.Output.Queries;
using FootStore.Application.Requests;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FootStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/Products")]
    public class ProductsQueriesController(IQueryMediator queryMediator) : ControllerBase
    {
        /// <summary>
        ///   Consult products of store by id
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProductAsync([FromQuery] GetProducRequest request, CancellationToken cancellationToken)
        {
            var result = await queryMediator.QueryAsync(new GetProductQuery(request), cancellationToken);

            if (result.IsFailure)
            {
                return NotFound(result.Error);
            }

            return Ok(result.Data);
        }
    }
}