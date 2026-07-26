using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext
    {
         // 1- Register models
         public DbSet<Employee> Employees { get; set; }
         public DbSet<Department> Departments { get; set; }
         public DbSet<Project> Projects { get; set; }
         public DbSet<Dependent> Dependents { get; set; }
         public DbSet<empProj> empProjs { get; set; }
         public DbSet<DeptLocations> DeptLocations { get; set; }

        // 2- Configure database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Mohammed\\SQLEXPRESS;Database=CompanyProjectDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
