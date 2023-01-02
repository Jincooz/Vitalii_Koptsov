namespace SeleniumHomeTask.PageObjects
{
    internal class AdminJobDropDownMenuPageComponent : PageComponent
    {
        private readonly By _jobTitlesReferencePath = By.ClassName("oxd-topbar-body-nav-tab-link");
        public AdminJobDropDownMenuPageComponent(IWebElement webElement) : base(webElement) { }
        public void OpenJobTitleList()
        {
            FindElement(_jobTitlesReferencePath).Click();
        }
    }
}
