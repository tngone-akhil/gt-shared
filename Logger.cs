using System;
using System.IO;
using System.Text;
using TNG.Shared.Lib.Intefaces;
using TNG.Shared.Lib.Mongo;
using ILogger = TNG.Shared.Lib.Intefaces.ILogger;
using Newtonsoft.Json;

namespace TNG.Shared.Lib
{
    public class Logger : ILogger
    {
        public Logger()
        {

        }
        /// <summary>
        /// For logging application exceptions to a file stored in disk
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="method"></param>
        /// <param name="error"></param>
        /// <param name="ip"></param>
        public void LogError(string controller, string method, string error, string ip = "")
        {
            var csv = new StringBuilder();
            try
            {
                string value = controller + "/" + method;
                string dateOfLog = DateTime.UtcNow.ToString();
                var first = value;
                var second = error;
                var third = ip;
                var newLine = string.Format("{0},{1},{2},{3}", dateOfLog, first, second, third);
                csv.AppendLine(newLine);
                var log_path = System.IO.Directory.GetCurrentDirectory();
                File.AppendAllText("" + log_path + "_log.csv", csv.ToString());
            }
            catch
            {

            }

        }

    }
}