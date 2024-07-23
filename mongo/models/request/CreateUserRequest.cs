using System.ComponentModel.DataAnnotations;
public class CreateUserRequest
{
    [Required(ErrorMessage = "Name cannot be null or empty")]
    public string Name{get;set;}
    [Required(ErrorMessage = "Email cannot be null or empty")]
    public string Email{get;set;}
    [Required(ErrorMessage = "Phone Number cannot be null or empty")]
    public string PhoneNumber{get;set;}
    [Required(ErrorMessage = "Location cannot be null or empty")]
    public string Location{get;set;}
    [Required(ErrorMessage = "Role cannot be null or empty")]
    public string Role{get;set;}

}