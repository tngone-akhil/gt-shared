using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using TNG.Shared.Lib.Intefaces;
using TNG.Shared.Lib.Models.Auth;
using System.Net;
using System.Linq;
using System;
using MongoDB.Driver;
using TNG.Shared.Lib.Mongo.Models;

public class TNGAuthAttribute : TypeFilterAttribute
{
    public TNGAuthAttribute(string userType) : base(typeof(TNGAuthorizeFilter))
    {
        Arguments = new string[] { userType };
    }

    public TNGAuthAttribute() : base(typeof(TNGAuthorizeFilter))
    {
        Arguments = null;
    }
}

public class TNGAuthorizeFilter : IAuthorizationFilter
{
    readonly string _userType;
    public TNGAuthorizeFilter(string userType = "")
    {
        _userType = userType;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        bool isSuccess = false;
        bool isUserSuccess = false;
        bool isUserTokenRefreshRequired = false;
        bool isRolesDirty = false;
        try
        {
            IMongoLayer _db = context.HttpContext.RequestServices.GetService(typeof(IMongoLayer)) as IMongoLayer;
            string usrToken = context.HttpContext.Request.Headers["AUTHKEY"];
            IAuthenticationService authService = context.HttpContext.RequestServices.GetService(typeof(IAuthenticationService)) as IAuthenticationService;

            UserToken userToken = JsonConvert.DeserializeObject<UserToken>(authService.Decrypt(usrToken));
            userToken.OriginalToken = usrToken;

            var userFilter = Builders<MDBL_User>.Filter.Eq(user => user.UserId, userToken.UserId);
            var user = _db.LoadDocuments(MONGO_MODELS.USER, userFilter).FirstOrDefault();
            if (user != null && user.IsActive == false)
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.PreconditionFailed);
            }
            else if (user == null)
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.PreconditionFailed);
            }

            if (_userType != null)
            {
                isRolesDirty = true;
                isUserSuccess = handleUserTypeAuth(context, userToken, authService, out isUserTokenRefreshRequired);
                if (isUserSuccess && !isUserTokenRefreshRequired)
                {
                    isSuccess = true;
                }
            }
            else
            {
                authService.User = userToken;
                isSuccess = true;
            }

        }
        catch
        {
            //Something not right => need a logout/refresh
            isSuccess = true;
            context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
        }

        if (!isSuccess)
        {
            if (isUserTokenRefreshRequired && isUserSuccess && isRolesDirty)
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.PreconditionFailed);
            }
            else if (!isUserSuccess && !isUserTokenRefreshRequired && isRolesDirty)
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
            }
            else
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Unauthorized);
            }
        }
    }
    /// <summary>
    /// To handle user based authentication
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>    
    private bool handleUserTypeAuth(AuthorizationFilterContext context, UserToken userToken, IAuthenticationService authService, out bool isTokenRefreshRequired)
    {
        bool isSuccess = false;
        isTokenRefreshRequired = false;

        var roleRequired = _userType.Split(',');
        var roleAvailableAndPresent = roleRequired.Where(r => r == userToken.UserType).FirstOrDefault();
        if (_userType != "")
        {
            if (!string.IsNullOrEmpty(roleAvailableAndPresent))
            {
                authService.User = userToken;
                isSuccess = true;
                if (userToken.Expiry < DateTime.UtcNow)
                {
                    isTokenRefreshRequired = true;
                }
            }

        }
        return isSuccess;
    }
}