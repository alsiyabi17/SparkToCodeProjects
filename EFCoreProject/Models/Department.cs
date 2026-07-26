using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public double DepartmentSalary { get; set; }
        
        
        //WorkFor
        [InverseProperty("D")]
        public List<Employee> Employees { get; set; }
        
        //Manage
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public DateTime ManagementStartDate { get; set; }
    }
}
