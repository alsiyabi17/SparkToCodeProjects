using System.ComponentModel.DataAnnotations;

namespace EFCoreProject.Models;

public class Project
{
    [Key]
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectLocation { get; set; }
    
    // Public List<Employee> Employees { get; set; }
    
    public List<empProj> empProj { get; set; }
}