using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIsBascisHomework.Api.EndpointResult;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.Api
{
    internal class ListFolderApiEndpoint : ApiEndpoint
    {
        public ListFolderApiEndpoint(Dictionary<string, string> body)
        {
            _url = Configuration.Configs["ListFolderApiUrl"];
            HttpPostDictionary postDictionary = new HttpPostDictionary()
            {
                Url = _url
            };
            postDictionary.AddDictionary(body);
            _httpPost = postDictionary;
        }

        public override ApiEndPointResult Post()
        {
            HttpResponseMessage httpResponseMessage = _httpPost.Post();
            return new ListFolderApiEndpointResult(httpResponseMessage);
        }
    }
}
