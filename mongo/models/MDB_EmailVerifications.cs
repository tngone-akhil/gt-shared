using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDB_EmailVerifications
    {
        public string Email { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? VerifiedDate { get; set; }
        public string IPAddress { get; set; }
        public int Code { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime GeneratedDate { get; set; }
        public bool IsVerificationCompleted { get; set; }
        public bool IsExpired { get; set; }
        public string UUID { get; set; }
    }
}