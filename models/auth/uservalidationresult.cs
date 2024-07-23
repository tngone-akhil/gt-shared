
namespace TNG.Shared.Lib.Models.Auth
{
    public class UserValidationResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public string UserId { get; set; }
        public string UserType { get; set; }
        public bool IsEmailVerified { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

    }
}