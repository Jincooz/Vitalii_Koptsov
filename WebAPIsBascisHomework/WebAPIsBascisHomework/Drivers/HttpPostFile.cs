using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework.Drivers
{
    internal class HttpPostFile : HttpPost
    {
        public void AddFile(byte[] file, string fileName)
        {
            HttpContent httpContent = new ByteArrayContent(file);
            MediaTypeHeaderValue contentType = new("application/octet-stream");
            httpContent.Headers.ContentType = contentType;
            var webRequest = new HttpRequestMessage(HttpMethod.Post, Url)
            {
                Content = httpContent
            };
            string pathJson = "{\"path\":\"" + _folderName + "/" + fileName + "\"}";
            webRequest.Headers.Add("Dropbox-API-Arg", pathJson);
            _message = webRequest;
        }
    }
}
