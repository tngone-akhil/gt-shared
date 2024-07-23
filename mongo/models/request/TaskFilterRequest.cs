using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class TaskFilterRequest
{
    public string Concept { get; set; }
    public string Location { get; set; }
    public string POC { get; set; }
    public string Responsibility { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    [Required(ErrorMessage = "To Date cannot be null or Empty")]
    
    public DateOnly ToDate { get; set; }
    [Required(ErrorMessage = "To Date cannot be null or Empty")]
    public DateOnly FromDate { get; set; }
}