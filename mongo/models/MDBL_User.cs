using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using TNG.Shared.Lib.Mongo.Base;
using TNG.Shared.Lib.Mongo.Models;

namespace TNG.Shared.Lib.Mongo.Models
{
    [BsonIgnoreExtraElements]
    public class MDBL_User : TNGMongoBase
    {
        public string Username { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLocked { get; set; }
        public int? LoginAttempts { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public List<MDB_EmailVerifications> EmailVerifications{ get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPasswordResetRequested { get; set;}
        public string PhoneNumber{ get; set;}
        public string Location{ get; set;}
          public string Image{ get; set;}
        public DateTime? LastLogIn { get; set; }


    }
}
