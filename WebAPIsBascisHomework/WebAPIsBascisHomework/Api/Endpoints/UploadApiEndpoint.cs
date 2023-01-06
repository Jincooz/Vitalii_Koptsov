using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.Api
{
    internal class UploadApiEndpoint : ApiEndpoint
    {
        public UploadApiEndpoint(byte[] file, string dropboxFileName) 
        {
            _url = Configuration.Configs["UploadApiUrl"];
            HttpPostFile postFile = new()
            {
                Url = _url
            };
            postFile.AddFile(file, dropboxFileName);
            _httpPost = postFile;
        }
    }
}
