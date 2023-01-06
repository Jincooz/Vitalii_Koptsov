using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.Api
{
    internal class GetMetadataApiEndpoint : ApiEndpoint
    {
        public GetMetadataApiEndpoint(Dictionary<string, string> body)
        {
            _url = Configuration.Configs["GetMetadataApiUrl"];
            HttpPostDictionary postDictionary = new HttpPostDictionary()
            {
                Url = _url
            };
            postDictionary.AddDictionary(body);
            _httpPost = postDictionary;
        }
    }
}
