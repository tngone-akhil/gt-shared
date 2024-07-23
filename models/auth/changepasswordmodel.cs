
using System;
using System.Collections.Generic;

namespace TNG.Shared.Lib.Models.Auth
{
    /// <summary>
    /// Server User Token
    /// </summary>
    public class ChangePasswordModel
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserId { get; set; }

    }
}