namespace SeleniumHomeTask.PageObjects
{
    internal class JobTitleListPageObject : PageObject
    {
        private static readonly string _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewJobTitleList";
        private IWebElement AddButton => FindElement(By.ClassName("oxd-button"));
        private IWebElement DeleteSelectedButton => FindElement(By.ClassName("oxd-button--label-danger"));
        private IWebElement PopUpWindow => FindElement(By.ClassName("orangehrm-dialog-popup"));
        private JobTitleListPageObjectr.JobTablePageComponent? JobTable;
        public JobTitleListPageObject(IWebDriver webDriver) : base(webDriver, _pageUrl) { }
        public SaveJobTitlePageObject ClickAdd()
        {
            AddButton.Click();
            return new SaveJobTitlePageObject(_webDriver);
        }
        public List<string> GetListOfJobTitlesInTable()
        {
            InitializeJobTable();
            return JobTable.GetListOfJobTitles();
        }
        public string GetJobDesctitionByJobTitle(string jobTitle)
        {
            InitializeJobTable();
            return JobTable.GetJobDesctitionByJobTitle(jobTitle);
        }
        public void CheckCheckboxWithJobTitle(string title)
        {
            InitializeJobTable();
            JobTable.CheckCheckboxWithJobTitle(title);
        }
        public JobTitleListPageObject DeleteSelected()
        {
            DeleteSelectedButton.Click();
            new JobTitleListPageObjectr.DeletionPopUpWindowPageComponent(PopUpWindow).ClickDelete();
            return new JobTitleListPageObject(_webDriver);
        }
        private void InitializeJobTable()
        {
            if (JobTable == null)
                JobTable = new(FindElement(By.ClassName("oxd-table")));
        }
    }
}
