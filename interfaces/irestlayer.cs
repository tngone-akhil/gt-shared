using RestSharp;

namespace TNG.Shared.Lib.Intefaces
{
    public interface IRestLayer
    {
        string MakeLocketRestCall(RestRequest req, string url, string pubToken = "");
    }
}