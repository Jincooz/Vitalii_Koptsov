using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework.Drivers
{
    internal class HttpPostDictionary : HttpPost
    {
        public void AddDictionary(Dictionary<string,string> content)
        {
            if (content.Keys.Contains("path"))
            {
                content["path"] = _folderName + content["path"];
            }
            string jsonContent = DictionaryToJson(content);
            HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            _message = new HttpRequestMessage(HttpMethod.Post, Url)
            {
                Content = httpContent
            };

            string DictionaryToJson(Dictionary<string, string> dict)
            {
                var entries = dict.Select(d =>
                    string.Format("\"{0}\": \"{1}\"", d.Key, d.Value));
                return "{" + string.Join(",", entries) + "}";
            }
        }
    }
}
