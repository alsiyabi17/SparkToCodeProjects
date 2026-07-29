using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class CategoryController
    {
        private ProjectContext context;

        public CategoryController(ProjectContext context)
        {
            context = context;
        }

        // Add Category
        public void AddCategory(Category c)
        {

            context.categories.Add(c);
            context.SaveChanges();
        }

        // Delete Category
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
        public Category GetCategory(int Id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == Id);
            return c;
        }

        // get all Category
        public List<Category> GetCategories()
        {
            List<Category> categories = context.categories.ToList();
            return categories;
        }
    }
}
