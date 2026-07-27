using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_CommerceDatabseTask.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }

        // One Category -> Many Products
        public List<Product> Products { get; set; } 
    }
}
