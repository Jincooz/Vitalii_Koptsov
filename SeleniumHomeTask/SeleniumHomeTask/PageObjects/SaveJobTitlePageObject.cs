namespace SeleniumHomeTask.PageObjects
{
    internal class SaveJobTitlePageObject : PageObject
    {
        private readonly By _jobTitleTextBoxPath = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/input");
        private readonly By _textBoxesPath = By.ClassName("oxd-textarea");
        private readonly By _saveButtonPath = By.ClassName("orangehrm-left-space");
        public SaveJobTitlePageObject(IWebDriver webDriver) : base(webDriver)
        {
            _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/saveJobTitle";
        }
        public void EnterJobTitle(string title)
        {
            IWebElement jobTitleTextBox = FindElement(_jobTitleTextBoxPath);
            jobTitleTextBox.Clear();
            jobTitleTextBox.SendKeys(title);
        }
        public void EnterJobDescription(string description)
        {
            IWebElement jobDescriptionTextBox = FindElements(_textBoxesPath)[0];
            jobDescriptionTextBox.Clear();
            jobDescriptionTextBox.SendKeys(description);
        }
        public void EnterJobNote(string note)
        {
            IWebElement noteTextBox = FindElements(_textBoxesPath)[1];
            noteTextBox.Clear();
            noteTextBox.SendKeys(note);
        }
        public JobTitleListPageObject ClickSave()
        {
            FindElement(_saveButtonPath).Click();
            return new JobTitleListPageObject(_webDriver);
        }
    }
}
