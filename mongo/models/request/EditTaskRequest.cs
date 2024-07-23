using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class EditTaskRequest
{
    [Required(ErrorMessage = "TaskId is Required")]
    public string TaskId{get;set;}
    public string TaskStatus{get;set;}
    public string Remarks{get;set;}
}