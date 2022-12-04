namespace SeleniumHomeTask.PageObjects.JobTitleListPageObjectr
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
