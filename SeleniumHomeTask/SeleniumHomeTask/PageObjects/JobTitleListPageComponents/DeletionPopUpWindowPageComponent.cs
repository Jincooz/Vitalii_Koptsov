namespace SeleniumHomeTask.PageObjects.JobTitleListPageComponents
{
    internal class DeletionPopUpWindowPageComponent : PageComponent
    {
        private IWebElement DeleteButton => FindElement(By.ClassName("oxd-button--label-danger"));
        public DeletionPopUpWindowPageComponent(IWebElement popUpWindow) : base(popUpWindow) { }
        public void ClickDelete()
        {
            DeleteButton.Click();
        }
    }
}
