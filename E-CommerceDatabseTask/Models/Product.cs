using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceDatabseTask.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }


        // Category -> Product (1:N)
        public int CategoryId { get; set; }

        public Category Category { get; set; }


        // Product -> OrderProduct (1:N)
        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}