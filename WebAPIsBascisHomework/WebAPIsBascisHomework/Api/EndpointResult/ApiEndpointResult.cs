using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework.Api
{
    internal class ApiEndPointResult
    {
        private readonly HttpStatusCode _statusCode;
        private readonly string _body;
        public HttpStatusCode StatusCode { get { return _statusCode;} }
        public string Body { get { return _body; } }
        public ApiEndPointResult(HttpResponseMessage httpResponseMessage)
        {
            _statusCode = httpResponseMessage.StatusCode;
            _body = httpResponseMessage.Content.ReadAsStringAsync().Result;
        }
    }
}
