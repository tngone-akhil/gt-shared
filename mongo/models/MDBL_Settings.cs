using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;

namespace TNG.Shared.Lib.Mongo.Models

{
    [BsonIgnoreExtraElements]
    public class MDBL_Settings: TNGMongoBase
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public string AppName { get; set; }
        public string Group { get; set; }
        public bool IsClientVisible { get; set; }
    }
}
