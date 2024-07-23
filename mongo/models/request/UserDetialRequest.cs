using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class UserDetialRequest
{
    [Required(ErrorMessage = "Page Number cannot be null or empty")]
    public int PageNumber { get; set; }
    [Required(ErrorMessage = "Rows per page cannot be null or empty")]
    public int RowsPerPage { get; set; }
}