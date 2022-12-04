namespace SeleniumHomeTask.PageObjects
{
    internal class SaveJobTitlePageObject : PageObject
    {
        private static readonly string _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/saveJobTitle";
        private IWebElement JobTitleTextBox => FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/input"));
        private IWebElement JobDescriptionTextBox => FindElements(By.ClassName("oxd-textarea"))[0];
        private IWebElement NoteTextBox => FindElements(By.ClassName("oxd-textarea"))[1];
        private IWebElement SaveButton => FindElement(By.ClassName("orangehrm-left-space"));
        public SaveJobTitlePageObject(IWebDriver webDriver) : base(webDriver, _pageUrl) { }
        public void EnterJobTitle(string title)
        {
            JobTitleTextBox.Clear();
            JobTitleTextBox.SendKeys(title);
        }
        public void EnterJobDescription(string description)
        {
            JobDescriptionTextBox.Clear();
            JobDescriptionTextBox.SendKeys(description);
        }
        public void EnterJobNote(string note)
        {
            NoteTextBox.Clear();
            NoteTextBox.SendKeys(note);
        }
        public JobTitleListPageObject ClickSave()
        {
            SaveButton.Click();
            return new JobTitleListPageObject(_webDriver);
        }
    }
}
