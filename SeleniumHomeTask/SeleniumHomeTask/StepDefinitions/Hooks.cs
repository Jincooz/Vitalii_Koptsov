using SeleniumHomeTask.Drivers;

namespace SeleniumHomeTask.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void SetupAlureDirectory()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(Directory.GetCurrentDirectory());
        }
        [BeforeScenario]
        public static void SetupScenario()
        {
            Driver.StartBrowser();
        }
        [AfterScenario]
        public static void CloseBrowser()
        {
            Driver.StopBrowser();
        }
    }
}