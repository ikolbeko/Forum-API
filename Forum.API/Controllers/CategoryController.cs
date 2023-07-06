using Forum.Models.Entities;
using Forum.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Forum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly TopicCategoryRepository _category;

        public CategoryController(TopicCategoryRepository category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_category);
        }

        [HttpPost]
        public IActionResult PostAddCategory([FromBody] TopicCategory category)
        {
            _category.Add(category);
            return Ok();
        }
    }
}
