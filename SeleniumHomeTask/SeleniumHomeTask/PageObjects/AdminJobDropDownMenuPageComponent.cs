namespace SeleniumHomeTask.PageObjects
{
    internal class AdminJobDropDownMenuPageComponent : PageComponent
    {
        private IWebElement JobTitlesReference => FindElement(By.ClassName("oxd-topbar-body-nav-tab-link"));
        public AdminJobDropDownMenuPageComponent(IWebElement webElement) : base(webElement) { }
        public void OpenJobTitleList()
        {
            JobTitlesReference.Click();
        }
    }
}
