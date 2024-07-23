
using System;
using System.Collections.Generic;
using TNG.Shared.Lib.Settings;

namespace TNG.Shared.Lib.Models.Auth
{
    /// <summary>
    /// Server User Token
    /// </summary>
    public class UserToken
    {
        public string UserId { get; set; }

        public string TokenId { get; set; }

        public string UserType { get; set; }

        public DateTime Expiry { get; set; }

        public string RequestIP { get; set; }

        //To be replaced with server timezone, since for the scope...
        //...of this application its going to be scaled as single region..
        //...multi-server deployment at max. And not planning to be multi-server...
        //...mult-region deployments
        public string TimeZone { get; set; }

        public string Id { get; set; }

        //Optional property to access original token
        //Not to be serialized for encryption
        //Strictly for business services only
        public string OriginalToken { get; set; }



    }
}