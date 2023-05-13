using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpGet]
        [Route("get2")]
        public IActionResult Get2()
        {
            return Ok("Hello World!2");
        }
    }
}
