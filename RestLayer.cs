using Microsoft.AspNetCore.Http;
using TNG.Shared.Lib.Intefaces;
using RestSharp;
using System;

namespace TNG.Shared.Lib
{
    public class RestLayer : IRestLayer
    {
        

        public string MakeLocketRestCall(RestRequest request, string url, string pubToken = "")
        {
            try
            {
                var client = new RestClient(url);
                request.AddHeader("LOCKETAUTHKEY", pubToken);
                var response = client.Execute(request);
                return response.Content;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return string.Empty;

        }




    }
}