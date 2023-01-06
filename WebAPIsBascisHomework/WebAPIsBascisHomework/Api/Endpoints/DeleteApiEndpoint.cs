using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.Api
{
    internal class DeleteApiEndpoint : ApiEndpoint 
    {
        public DeleteApiEndpoint(Dictionary<string,string> body) 
        {
            _url = Configuration.Configs["DeleteApiUrl"];
            HttpPostDictionary postDictionary = new HttpPostDictionary()
            {
                Url = _url
            };
            postDictionary.AddDictionary(body);
            _httpPost = postDictionary;
        }
    }
}
