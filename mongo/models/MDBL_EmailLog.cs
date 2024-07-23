using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_EmailLog : TNGMongoBase
    {
        public string To { get; set; }
        public string EmailUID { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? SentTime { get; set; }
        public string Content { get; set; }
        public bool IsHTML { get; set; }
        public bool IsSent { get; set; }
        public bool IsFailed { get; set; }
        public string ErrorMessage { get; set; }
        public string Subject { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime Updated { get; set; }

    }

}
