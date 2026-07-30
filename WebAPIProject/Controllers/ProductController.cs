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
        public IActionResult AddProduct(Product p)
        {

            context.products.Add(p);
            context.SaveChanges();

            return Ok(p.ProductId); 
        }

        // delete product by id 
        [HttpDelete("RemoveProduct")]
        public IActionResult RemoveProduct(int Id)
        {

            Product p = context.products.FirstOrDefault(p => p.ProductId == Id);
            if (p == null) 
            {
                return NotFound("Product Not Found");
            }
            else
            {
                context.products.Remove(p);
                context.SaveChanges();
                return Ok("removed successfully");
            }
        }

        // Update ProductPrice
        [HttpPatch("UpdateProductPrice")]
        public IActionResult UpdateProductPrice(int id,double newPrice)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            p.ProductPrice = newPrice;
            context.SaveChanges();
            return Ok();
        }

        // Update ProductName
        [HttpPatch("UpdateProductName")]
        public IActionResult UpdateProductName(int id, string newName)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            p.ProductName = newName;
            context.SaveChanges();
            return Ok();
        }

        // Update All
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(int id, Product newProduct)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.ProductPrice = newProduct.ProductPrice;
            p.ProductName = newProduct.ProductName;
            p.ProductDescription = newProduct.ProductDescription;

            context.SaveChanges();
            return Ok();
        }

        // get product by id
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int Id) 
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == Id);
            return Ok(p);
        }

        // get all products
        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts() 
        {
            List<Product> products = context.products.ToList();
            return Ok("products");
        }

        // Get byName
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            List<Product> products = context.products.Where(p => p.ProductName.Contains(name)).ToList();
            return Ok("products");
        }


    }
}
