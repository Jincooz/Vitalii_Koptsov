using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumHomeTask.Drivers
{
    public static class Driver
    {

        private static IWebDriver _browser;

        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }

                return _browser;
            }
            private set
            {
                _browser = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Firefox)
        {
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                case BrowserTypes.InternetExplorer:
                    Browser = new InternetExplorerDriver();
                    break;
                case BrowserTypes.Chrome:
                    Browser = new ChromeDriver();
                    break;
                default:
                    break;
            }
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
        }
    }
}