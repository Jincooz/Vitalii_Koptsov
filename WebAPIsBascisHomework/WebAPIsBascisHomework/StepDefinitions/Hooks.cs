using TechTalk.SpecFlow;
using WebAPIsBascisHomework.Api;
using WebAPIsBascisHomework.Drivers;

namespace WebAPIsBascisHomework.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeFeature]
        public static void CreateFolder()
        {
            Dictionary<string, string> content = new()
            {
                {"path", ""}
            };
            ApiEndpoint endpoint = ApiStaicFactory.GetCreateFolderApi(content);
            endpoint.Post();
        }
        [AfterFeature]
        public static void DeleteFolder()
        {
            Dictionary<string, string> content = new()
            {
                {"path", ""}
            };
            ApiEndpoint endpoint = ApiStaicFactory.GetDeleteApi(content);
            endpoint.Post();
        }
    }
}