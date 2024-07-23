using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class NotificationRequest
{
    [Required(ErrorMessage ="Page number cannot be null or empty")]
    public int PageNumber{get;set;}
     [Required(ErrorMessage ="Rows per page cannot be null or empty")]
     public int RowsPerPage{get;set;}
}