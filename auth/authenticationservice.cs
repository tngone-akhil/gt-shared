using TNG.Shared.Lib.Intefaces;
using System.Security.Cryptography;
using System.Text;
using TNG.Shared.Lib.Models.Auth;
using TNG.Shared.Lib.Settings;
using System;
using System.IO;

namespace TNG.Shared.Lib
{
    public class AuthenticationService : IAuthenticationService
    {
        private CryptoSettings _cryptoSettings;

        public UserToken User { get; set; }

        public AuthenticationService(CryptoSettings cryptoSetting)
        {
            this._cryptoSettings = cryptoSetting;
        }

        /// <summary>
        /// Encrypt information using AES
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Encrypted string</returns>
        public string Encrypt(string data)
        {
            var encodedData = System.Text.Encoding.UTF8.GetBytes(data);
            using (var aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(this._cryptoSettings.Key);
                aes.IV = Convert.FromBase64String(this._cryptoSettings.IV);
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    using (var resultStream = new MemoryStream())
                    {
                        using (var aesStream = new CryptoStream(resultStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (var plainStream = new MemoryStream(encodedData))
                            {
                                plainStream.CopyTo(aesStream);
                            }
                        }
                        return Convert.ToBase64String(resultStream.ToArray());
                    }
                }
            }
        }

        /// <summary>
        /// To Decrypt cipher using AES
        /// </summary>
        /// <param name="cipher"></param>
        /// <returns></returns>
        public string Decrypt(string cipher)
        {
            var cipherBytes = Convert.FromBase64String(cipher);
            using (var aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(this._cryptoSettings.Key);
                aes.IV = Convert.FromBase64String(this._cryptoSettings.IV);
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    using (var resultStream = new MemoryStream())
                    {
                        using (var aesStream = new CryptoStream(resultStream, decryptor, CryptoStreamMode.Write))
                        {
                            using (var plainStream = new MemoryStream(cipherBytes))
                            {
                                plainStream.CopyTo(aesStream);
                            }
                        }
                        return Encoding.UTF8.GetString(resultStream.ToArray());
                    }
                }
            }
        }
    }
}