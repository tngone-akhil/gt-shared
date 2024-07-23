
using TNG.Shared.Lib.Models.Auth;

namespace TNG.Shared.Lib.Intefaces
{
    public interface IAuthenticationService
    {

        UserToken User { get; set; }

        string Encrypt(string data);

        string Decrypt(string cipher);

    }
}