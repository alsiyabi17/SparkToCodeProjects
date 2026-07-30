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
        public void AddCategory(Category c)
        {

            context.categories.Add(c);
            context.SaveChanges();
        }

        // Delete Category
        [HttpDelete("RemoveCategoryt")]
        public void RemoveCategoryt(int Id)
        {

            Category c = context.categories.FirstOrDefault(c => c.CategoryId == Id);
            if (c == null)
            {
            }
            else
            {
                context.categories.Remove(c);
                context.SaveChanges();
            }
        }


        // get Category by id
        [HttpGet("GetCategory")]
        public Category GetCategory(int Id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == Id);
            return c;
        }

        // get all Category
        [HttpGet("GetAllCategories")]
        public List<Category> GetAllCategories()
        {
            List<Category> categories = context.categories.ToList();
            return categories;
        }
    }
}
