using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.Api
{
    internal abstract class ApiEndpoint
    {
        protected string _url;
        protected HttpPost _httpPost;
        public virtual ApiEndPointResult Post()
        {
            HttpResponseMessage httpResponseMessage = _httpPost.Post(); 
            return new ApiEndPointResult(httpResponseMessage);
        }
    }
}
