using TNG.Shared.Lib.Communications.Email;

namespace TNG.Shared.Lib.Intefaces
{
    public interface IEmailer
    {
        /// <summary>
        /// Send a mail
        /// </summary>
        /// <param name="email"></param>
         bool SendMail(TNGEmail email);
         bool SendMailSendGrid(TNGEmail email);
    }
}