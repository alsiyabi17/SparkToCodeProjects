using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceDatabseTask.Models
{
    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderProduct
    {
        public int Quantity { get; set; }
    }
}
