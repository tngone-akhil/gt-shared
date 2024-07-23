
using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class ChangeUserPasswordRequest
{
    [Required(ErrorMessage = "Password cannot be null or empty")]
    public string Password { get; set; }
    [Required(ErrorMessage = "ConfirmPassword cannot be null or empty")]
    public string ConfirmPassword { get; set; }
}