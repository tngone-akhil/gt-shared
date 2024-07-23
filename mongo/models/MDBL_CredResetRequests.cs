using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_CredResetRequests : TNGMongoBase
    {
        public string UserGuid { get; set; }    
        public string UUID { get; set; }    
        public string ToEmail { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime ResetCompletionDate { get; set; }
        public string IPAddress { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime GeneratedDate { get; set; }

        public bool IsResetRequestCompleted { get; set; }
        
        public bool IsExpired { get; set; }

    }
}
