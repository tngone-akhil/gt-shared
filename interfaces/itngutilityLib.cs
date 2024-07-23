using System;

namespace TNG.Shared.Lib.Intefaces
{
    public interface ITNGUtiltityLib
    {
        DateTime? convertDateTimeFromDB(object data);
        object convertDateTimeFromUtc(object utcTime);
        DateTime getCurrentTime(DateTime? dateTime = null);
        object ConvertTimeToUtc(object dateTime);
        string getRandomString();
        string CONCATENATE(string FirstName, string LastName);
        string ConvertTimeFormat(DateTime d1);
        string ConvertDateFormat(DateTime d1);
        string GetDuration(DateTime startTime, DateTime endTime);



    }
}