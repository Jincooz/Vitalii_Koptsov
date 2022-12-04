namespace SeleniumHomeTask.PageObjects
{
    internal class DashboardPageObject : PageObject
    {
        private static readonly string _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
        private IWebElement AdminMenuItem => FindElement(By.CssSelector("a.oxd-main-menu-item"));
        public DashboardPageObject(IWebDriver webDriver) : base(webDriver, _pageUrl) { }
        public SystemUsersPageObject GoToAdminPage()
        {
            AdminMenuItem.Click();
            return new SystemUsersPageObject(_webDriver);
        }
    }
}
