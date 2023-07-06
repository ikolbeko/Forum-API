using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Forum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopicController : Controller
    {
        [HttpGet]
        public IActionResult GetTopics()
        {
            // Логика получения списка постов

            // Возвращаем список постов
            return Ok("Get method");
        }
    }
}
