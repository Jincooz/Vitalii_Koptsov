using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace WebAPIsBascisHomework.Drivers
{
    internal class Client
    {
        private static readonly HttpClient client = new();
        private static string _token = string.Empty;
        private static Client _client = new();
        public static Client Instance
        {
            get 
            { 
                return _client;
            }
        }
        private Client() 
        {
            GetToken();
        }
        private void GetToken()
        {
            _token = Configuration.Configs["Token"];
        }
        public HttpResponseMessage Post(HttpRequestMessage webRequest)
        {
            webRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            return client.Send(webRequest);
        }
    }
}
