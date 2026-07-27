using E_CommerceDatabseTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceDatabseTask
{
    public class ProjectContext : DbContext
    {
        // Register Models
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        // 2- Configure database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Mohammed\\SQLEXPRESS;Database=E_CommerceDatabse;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
