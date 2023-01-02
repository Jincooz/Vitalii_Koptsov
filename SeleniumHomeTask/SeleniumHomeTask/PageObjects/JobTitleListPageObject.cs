namespace SeleniumHomeTask.PageObjects
{
    internal class JobTitleListPageObject : PageObject
    {
        private readonly By _addButtonPath = By.ClassName("oxd-button");
        private readonly By _deleteSelectedButtonPath = By.ClassName("oxd-button--label-danger");
        private readonly By _popUpWindowPath = By.ClassName("orangehrm-dialog-popup");
        private JobTitleListPageComponents.JobTablePageComponent? JobTable;//TODO: Add private property for lazy loading JobTable
        public JobTitleListPageObject(IWebDriver webDriver) : base(webDriver) 
        { 
            _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewJobTitleList"; 
        }
        public SaveJobTitlePageObject ClickAdd()
        {
            FindElement(_addButtonPath).Click();
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
            FindElement(_deleteSelectedButtonPath).Click();
            new JobTitleListPageComponents.DeletionPopUpWindowPageComponent(FindElement(_popUpWindowPath)).ClickDelete();
            return new JobTitleListPageObject(_webDriver);
        }
        private void InitializeJobTable()
        {
            JobTable ??= new(FindElement(By.ClassName("oxd-table")));
        }
    }
}
