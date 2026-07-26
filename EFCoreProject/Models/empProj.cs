using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Models;

[PrimaryKey(nameof(EmployeeId), nameof(ProjectId))]

public class empProj
{

    [ForeignKey("emp")]
    public int EmployeeId { get; set; }
    public Employee emp { get; set; }
    
    [ForeignKey("proj")]
    public int ProjectId { get; set; }
    public Project proj { get; set; }
    
    public int Hours  { get; set; } 
}