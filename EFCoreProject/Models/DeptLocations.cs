using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Models;

[PrimaryKey(nameof(DepartmentId), nameof(DepartmentLocation))]

public class DeptLocations
{
    [ForeignKey("Dept")]
    public int DepartmentId { get; set; }
    public Department Dept { get; set; }
    
    
    public string DepartmentLocation { get; set; }
}