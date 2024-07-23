using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_Notification : TNGMongoBase
    {
        public string UserId{ get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }

    }

}
