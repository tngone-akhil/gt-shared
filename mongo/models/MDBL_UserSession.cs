using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_UserSession : TNGMongoBase
    {

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? SessionStart { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? SessionEnd { get; set; }

        public string UserGuid { get; set; }

        public bool? IsActive { get; set; }

        public string InitialTokenObject { get; set; }

        public int RefreshCount { get; set; }

        public string LastIssuedRefreshTokenObject { get; set; }

        public string UserId { get; set; }
    }
}
