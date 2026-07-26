using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }

        
        
        //WorkFor 1 - M
        [ForeignKey("D")]
        public int DepartmentId { get; set; }
        public Department D { get; set; }
        
        //Manage
        [InverseProperty("Employee")]
        public Department ManageDepart { get; set; }
        
        //Dependent 1 - 1
        public Dependent Dependent { get; set; }
        
        //WorkOn M - M
        // public List<Project> projects { get; set; }
        public List<empProj> empProjs { get; set; }
        
        
        //Self-relationship
        //Supervision
        [InverseProperty("supervisor")]
        public List<Employee> supervisee { get; set; }
        
        [ForeignKey("Supervisor")]
        public int SupervisorId { get; set; }
        public Employee Supervisor { get; set; }
        
    }
}
