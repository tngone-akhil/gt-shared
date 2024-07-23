using System;
using System.Collections.Generic;
using Amazon;

namespace TNG.Shared.Lib.Mongo.Master
{
    public class S3LayerSettings
    {
        public string accessKeyId { get; set; }
        public string accessSecretKey { get; set; }
        public string bucket { get; set; }
    }
}