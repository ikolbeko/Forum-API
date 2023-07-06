using Microsoft.AspNetCore.Mvc;

namespace Forum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok();
        }
    }
}
