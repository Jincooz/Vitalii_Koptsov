using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework.Api
{
    internal class ApiStaicFactory
    {
        public static CreateFolderApiEndpoint GetCreateFolderApi(Dictionary<string, string> body)
        {
            return new CreateFolderApiEndpoint(body);
        }
        public static DeleteApiEndpoint GetDeleteApi(Dictionary<string, string> body)
        {
            return new DeleteApiEndpoint(body);
        }
        public static GetMetadataApiEndpoint GetMetadataApi(Dictionary<string, string> body)
        {
            return new GetMetadataApiEndpoint(body);
        }
        public static ListFolderApiEndpoint GetListFolderApi(Dictionary<string, string> body)
        {
            return new ListFolderApiEndpoint(body);
        }
        public static UploadApiEndpoint GetUploadApi(byte[] file, string dropboxFileName)
        {
            return new UploadApiEndpoint(file, dropboxFileName);
        }
    }
}
