using Microsoft.AspNetCore.Mvc;

namespace MoneyManager.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return Ok();
        }
    }
}
