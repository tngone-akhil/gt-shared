namespace TNG.Shared.Lib.Intefaces
{
    public interface ISettingservice
    {

        /// <summary>
        /// to load all settings
        /// </summary>
        void LoadSettings();

        /// <summary>
        /// to load get all settings
        /// </summary>
        string GetSetting(string key);

        /// <summary>
        /// To load all settings and retrieve a payment setting
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetPaymentSetting(string key);
    }
}