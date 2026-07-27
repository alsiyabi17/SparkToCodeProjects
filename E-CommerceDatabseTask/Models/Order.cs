using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceDatabseTask.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("UID")]
        public int UserId { get; set; }
        public User UID { get; set; }

        // M - M
        public List<OrderProduct> OrderProducts { get; set; }

        // 1 - M
        public Review Review { get; set; }
    }
}
