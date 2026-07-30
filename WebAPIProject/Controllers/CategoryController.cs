using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private ProjectContext context;

        public CategoryController(ProjectContext context)
        {
            context = context;
        }

        // Add Category
        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category c)
        {

            context.categories.Add(c);
            context.SaveChanges();
            return Ok();
        }

        // Delete Category
        [HttpDelete("RemoveCategoryt")]
        public IActionResult RemoveCategoryt(int Id)
        {

            Category c = context.categories.FirstOrDefault(c => c.CategoryId == Id);
            if (c == null)
            {
                return NotFound();
            }
            else
            {
                context.categories.Remove(c);
                context.SaveChanges();
                return Ok();
            }
        }


        // get Category by id
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int Id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == Id);
            return Ok("c");
        }

        // get all Category
        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            List<Category> categories = context.categories.ToList();
            return Ok("categories");
        }
    }
}
