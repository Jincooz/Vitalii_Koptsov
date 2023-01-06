using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework.Drivers
{
    internal abstract class HttpPost
    {
        protected string _folderName = "/fff";
        protected HttpRequestMessage _message;
        public string Url { get; set; }
        public HttpPost()
        {

        }
        public HttpPost(string url)
        {
            Url = url;
        }

        public HttpResponseMessage Post()
        {
            return Client.Instance.Post(_message);
        }
    }
}
