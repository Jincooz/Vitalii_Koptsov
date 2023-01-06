using TechTalk.SpecFlow;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeFeature]
        public static void CreateFolder()
        {
            HttpPostDictionary httpPost = new HttpPostDictionary()
            {
                Url = "https://api.dropboxapi.com/2/files/create_folder_v2",
            };
            Dictionary<string, string> content = new()
            {
                {"path", ""}
            };
            httpPost.AddDictionary(content);
            httpPost.Post();
        }
        [AfterFeature]
        public static void DeleteFolder()
        {
            HttpPostDictionary httpPost = new HttpPostDictionary()
            {
                Url = "https://api.dropboxapi.com/2/files/delete_v2",
            };
            Dictionary<string, string> content = new()
            {
                {"path", ""}
            };
            httpPost.AddDictionary(content);
            httpPost.Post();
        }
    }
}