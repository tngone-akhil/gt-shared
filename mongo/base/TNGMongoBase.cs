using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Base
{
    public class TNGMongoBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public bool IsDeleted { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime UpdatedDate { get; set; }
    }
}