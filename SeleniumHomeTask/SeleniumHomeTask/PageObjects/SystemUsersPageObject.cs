namespace SeleniumHomeTask.PageObjects
{
    internal class SystemUsersPageObject : PageObject
    {
        private readonly By _topMenuPath = By.ClassName("oxd-topbar-body-nav-tab");
        private AdminJobDropDownMenuPageComponent? JobMenu;//TODO: Add private property for lazy loading JobMenu
        public SystemUsersPageObject(IWebDriver webDriver) : base(webDriver)
        {
            _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers";
        }
        public JobTitleListPageObject OpenJobTitleList()
        {
            FindElements(_topMenuPath)[1].Click();
            InitializeJobMenu();
            JobMenu.OpenJobTitleList();
            return new JobTitleListPageObject(_webDriver);
        }
        private void InitializeJobMenu()
        {
            JobMenu ??= new AdminJobDropDownMenuPageComponent(FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul")));
        }
    }
}

