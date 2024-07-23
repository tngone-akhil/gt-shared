using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class VerifyEmailRequest
    {
        [Required(ErrorMessage = "Email cannot be null or empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Code cannot be null or empty")]
        public string Code { get; set; }
    }
}