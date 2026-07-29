using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class ProductController
    {
        private ProjectContext context;

        public ProductController(ProjectContext context)
        {
            context = context;
        }
        //ProjectContext context = new ProjectContext();

        // Add Product
        public void AddProduct(Product p)
        {

            context.products.Add(p);
            context.SaveChanges();
        }

        // delete product by id 
        public void RemoveProduct(int Id)
        {

            Product p = context.products.FirstOrDefault(p => p.ProductId == Id);
            if (p == null) 
            {
            }
            else
            {
                context.products.Remove(p);
                context.SaveChanges();
            }
        }


        // Update ProductPrice
        public void UpdateProductPrice(int id,double newPrice)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            p.ProductPrice = newPrice;
            context.SaveChanges();
        }

        // Update ProductName
        public void UpdateProductName(int id, string newName)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            p.ProductName = newName;
            context.SaveChanges();
        }

        // get product by id
        public Product GetProduct(int Id) 
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == Id);
            return p;
        }

        // get all products
        public List<Product> GetAllProducts() 
        {
            List<Product> products = context.products.ToList();
            return products;
        }

        // Get byName
        public List<Product> GetByName(string name)
        {
            List<Product> products = context.products.Where(p => p.ProductName.Contains(name)).ToList();
            return products;
        }


    }
}
