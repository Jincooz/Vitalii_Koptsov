using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask.StepDefinitions
{
    [Binding]
    internal class Hooks
    {
        [BeforeTestRun]
        public static void SetupAlureDirectory()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(Directory.GetCurrentDirectory());
        }
        [BeforeScenario]
        public static void SetupScenario()
        {
            DoSomeShit();
        }
    }
}