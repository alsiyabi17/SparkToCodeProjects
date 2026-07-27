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
    }
}
