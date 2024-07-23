namespace TNG.Shared.Lib.Models.Auth
{
    public class AuthTokenRefreshModel
    {
        public bool Success { get; set; }

        public string Token { get; set; }

        public bool IsReAuthRequired { get; set; }

    }
}