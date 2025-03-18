using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Greeter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreeterController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string name = "anonymous")
        {
            return Ok($"Hello {name}");
        }
    }
}
