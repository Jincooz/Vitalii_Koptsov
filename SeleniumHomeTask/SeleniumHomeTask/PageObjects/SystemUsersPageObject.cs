namespace SeleniumHomeTask.PageObjects
{
    internal class SystemUsersPageObject : PageObject
    {
        private readonly By _topMenuPath = By.ClassName("oxd-topbar-body-nav-tab");
        private readonly By _jobMenuPath = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul");
        private AdminJobDropDownMenuPageComponent? _jobMenu;
        private AdminJobDropDownMenuPageComponent? JobMenu
        {
            get
            {
                _jobMenu ??= new AdminJobDropDownMenuPageComponent(FindElement(_jobMenuPath));
                return _jobMenu;
            }
        }
        public SystemUsersPageObject(IWebDriver webDriver) : base(webDriver)
        {
            _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers";
        }
        public JobTitleListPageObject OpenJobTitleList()
        {
            FindElements(_topMenuPath)[1].Click();
            JobMenu.OpenJobTitleList();
            return new JobTitleListPageObject(_webDriver);
        }
    }
}

