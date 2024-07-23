using System;
using System.Collections.Generic;
using Amazon;

namespace TNG.Shared.Lib.Mongo.Common
{
    public class ERROR_SETTINGS
    {
        public static string USER_NOT_FOUND = "USER_NOT_FOUND";
        public static string USER_HAS_BEEN_LOCKED_BY_ADMIN = "USER_HAS_BEEN_LOCKED_BY_ADMIN";
        public static string EMAIL_ID_ALREADY_EXISTS = "EMAIL_ID_ALREADY_EXISTS";
        public static string PASSWORD_MISMATCH = "PASSWORD_MISMATCH";
        public static string TIME_OUT_ERR = "TIME_OUT_ERR";
        public static string WRONG_CODE_ERR = "WRONG_CODE_ERR";
        public static string FACEBOOK_ACCOUNT_EMAIL_NOT_FOUND = "FACEBOOK_ACCOUNT_EMAIL_NOT_FOUND";
        public static string INVALID_LOGIN = "INVALID_LOGIN";
        public static string LOGIN_LIMIT_EXCEEDED = "LOGIN_LIMIT_EXCEEDED";
        public static string PROFILE_LOCKED_BY_ADMIN = "PROFILE_LOCKED_BY_ADMIN";
        public static string WRONG_OLD_PASSWORD = "WRONG_OLD_PASSWORD";
        public static string RESET_NOT_REQUESTED = "RESET_NOT_REQUESTED";
        public static string PASSWORD_NOT_SET = "PASSWORD_NOT_SET";
        public static string INVALID_TOKEN = "INVALID_TOKEN";
        public static string INVALID_TASK="TASK_NOT_FOUND";
        public static string TASK_FAILURE="TASK_CREATION_REQUEST_FAILED";
        public static string UPDATION_FAILED="UPDATION_FAILED";
        



    }
}