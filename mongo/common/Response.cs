using MongoDB.Bson.Serialization.Attributes;

namespace TNG.Shared.Lib.Mongo.Common
{
    public class LocketResponse
    {
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
    }
}