namespace SeleniumHomeTask.PageObjects
{
    internal class DashboardPageObject : PageObject
    {
        private readonly By _adminMenuItemPath = By.CssSelector("a.oxd-main-menu-item");
        public DashboardPageObject(IWebDriver webDriver) : base(webDriver) 
        { 
            _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"; 
        }
        public SystemUsersPageObject GoToAdminPage()
        {
            FindElement(_adminMenuItemPath).Click();
            return new SystemUsersPageObject(_webDriver);
        }
    }
}
