using System;

namespace TNG.Shared.Lib.Intefaces
{

    /// <summary>
    /// Interface for general logging operations
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// To Log error
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="method"></param>
        /// <param name="ip"></param>
        /// <param name="error"></param>

        void LogError(string controller, string method, string error, string ip = "");

    }
}