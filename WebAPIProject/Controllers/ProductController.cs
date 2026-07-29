using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private ProjectContext context;

        public ProductController(ProjectContext context)
        {
            context = context;
        }
        //ProjectContext context = new ProjectContext();

        // Add Product
        [HttpPost("AddProduct")]
        public void AddProduct(Product p)
        {

            context.products.Add(p);
            context.SaveChanges();
        }

        // delete product by id 
        [HttpDelete("RemoveProduct")]
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
        [HttpPatch("UpdateProductPrice")]
        public void UpdateProductPrice(int id,double newPrice)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            p.ProductPrice = newPrice;
            context.SaveChanges();
        }

        // Update ProductName
        [HttpPatch("UpdateProductName")]
        public void UpdateProductName(int id, string newName)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            p.ProductName = newName;
            context.SaveChanges();
        }

        // Update All
        [HttpPut("UpdateProduct")]
        public void UpdateProduct(int id, Product newProduct)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.ProductPrice = newProduct.ProductPrice;
            p.ProductName = newProduct.ProductName;
            p.ProductDescription = newProduct.ProductDescription;

            context.SaveChanges();
        }


        // get product by id
        [HttpGet("GetProduct")]
        public Product GetProduct(int Id) 
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == Id);
            return p;
        }

        // get all products
        [HttpGet("GetAllProducts")]
        public List<Product> GetAllProducts() 
        {
            List<Product> products = context.products.ToList();
            return products;
        }

        // Get byName
        [HttpGet("GetByName")]
        public List<Product> GetByName(string name)
        {
            List<Product> products = context.products.Where(p => p.ProductName.Contains(name)).ToList();
            return products;
        }


    }
}
