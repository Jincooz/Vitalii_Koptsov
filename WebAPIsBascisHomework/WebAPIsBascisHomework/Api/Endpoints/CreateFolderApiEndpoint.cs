using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.Api
{
    internal class CreateFolderApiEndpoint : ApiEndpoint
    {
        public CreateFolderApiEndpoint(Dictionary<string, string> body) 
        {
            _url = Configuration.CreateFolderApiUrl;
            HttpPostDictionary postDictionary = new HttpPostDictionary()
            {
                Url = _url
            };
            postDictionary.AddDictionary(body);
            _httpPost = postDictionary;
        }
    }
}
