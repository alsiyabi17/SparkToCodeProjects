using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceDatabseTask.Models
{
    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderProduct
    {
        [ForeignKey("OID")]
        public int OrderId { get; set; }

        public Order OID { get; set; }


        [ForeignKey("PID")]
        public int ProductId { get; set; }

        public Product PID { get; set; }

        public int Quantity { get; set; }
    }
}