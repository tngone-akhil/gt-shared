using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class EditUserRequest
{
    [Required(ErrorMessage = "UserId is Required")]
    public string UserId{get;set;}
    public string Username{get;set;}
    public string Location{get;set;}
    public string PhoneNumber{get;set;}
}