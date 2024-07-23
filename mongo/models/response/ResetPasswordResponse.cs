using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    public class ResetPasswordResponse
    {
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
        public string UserId { get; set; }
    }
}