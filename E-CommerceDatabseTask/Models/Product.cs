using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceDatabseTask.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        [ForeignKey("CID")]
        public int CategoryId { get; set; }
        public Category CID { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }


    }
}
