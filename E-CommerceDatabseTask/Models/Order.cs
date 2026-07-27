using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceDatabseTask.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        // User -> Order (1:N)
        [ForeignKey("UID")]
        public int UserId { get; set; }

        public User UID { get; set; }

        // Order -> OrderProduct (1:N)
        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

        // Order -> Review (1:1)
        public Review Review { get; set; }
    }
}