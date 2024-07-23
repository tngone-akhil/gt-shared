namespace TNG.Shared.Lib.Intefaces
{
    public interface IFirebaseMessenger
    {
        /// <summary>
        /// Send a push notification
        /// </summary>
        /// <param name="devideId,message"></param>

        Task<string> SendNotificationAsync(string tokenid, string body, string title);

    }
}