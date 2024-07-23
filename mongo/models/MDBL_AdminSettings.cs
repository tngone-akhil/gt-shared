using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_AdminSettings : TNGMongoBase
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string LastUpdatedBy { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime LastNotificationSentOn { get; set; }

    }
}
