namespace SeleniumHomeTask.PageObjects
{
    internal class SystemUsersPageObject : PageObject
    {
        private static readonly string _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers";
        private IWebElement JobTitle => FindElements(By.ClassName("oxd-topbar-body-nav-tab"))[1];
        private AdminJobDropDownMenuPageComponent? JobMenu;
        public SystemUsersPageObject(IWebDriver webDriver) : base(webDriver, _pageUrl) { }
        public JobTitleListPageObject OpenJobTitleList()
        {
            JobTitle.Click();
            InitializeJobMenu();
            JobMenu.OpenJobTitleList();
            return new JobTitleListPageObject(_webDriver);
        }
        private void InitializeJobMenu()
        {
            if (JobMenu != null)
            {
                JobMenu = new AdminJobDropDownMenuPageComponent(FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul")));
            }
        }
    }
}

