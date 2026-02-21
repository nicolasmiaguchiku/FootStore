using Microsoft.AspNetCore.Mvc;

namespace FootStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/Products")]
    public class ProductsCommandController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Funcionando");
        }
    }
}