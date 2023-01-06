using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework.Api.EndpointResult
{
    internal class ListFolderApiEndpointResult : ApiEndPointResult
    {
        public ListFolderApiEndpointResult(HttpResponseMessage httpResponseMessage) : base(httpResponseMessage)
        {
        }

        public List<string> FileNames()
        {
            string re = "\"name\": \"(.*)\"";
            Regex regex = new Regex(re);
            var regexResult = regex.Matches(Body).Cast<Match>().ToList();
            return regexResult.Select(x => x.Groups[1].Value.ToString()).ToList();
        }
    }
}
