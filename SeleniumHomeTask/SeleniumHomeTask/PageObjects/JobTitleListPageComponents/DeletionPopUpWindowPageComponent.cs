namespace SeleniumHomeTask.PageObjects.JobTitleListPageComponents
{
    internal class DeletionPopUpWindowPageComponent : PageComponent
    {
        private readonly By _deleteButtonPath = By.ClassName("oxd-button--label-danger");
        public DeletionPopUpWindowPageComponent(IWebElement popUpWindow) : base(popUpWindow) { }
        public void ClickDelete()
        {
            FindElement(_deleteButtonPath).Click();
        }
    }
}
