using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Models;

[PrimaryKey(nameof(EmployeeId), nameof(DepartmentName))]

public class Dependent
{
    public int DependentId { get; set; }
    public string DependentName { get; set; }
    public string Relationship { get; set; }
    
    
    [ForeignKey("emp")]
    public int EmployeeId { get; set; }
    public Employee emp { get; set; }
}