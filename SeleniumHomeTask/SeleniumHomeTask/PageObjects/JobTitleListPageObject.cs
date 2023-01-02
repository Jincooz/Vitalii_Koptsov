namespace SeleniumHomeTask.PageObjects
{
    internal class JobTitleListPageObject : PageObject
    {
        private readonly By _addButtonPath = By.ClassName("oxd-button");
        private readonly By _deleteSelectedButtonPath = By.ClassName("oxd-button--label-danger");
        private readonly By _popUpWindowPath = By.ClassName("orangehrm-dialog-popup");
        private readonly By _jobTablePath = By.ClassName("oxd-table");
        private JobTitleListPageComponents.JobTablePageComponent? _jobTable;
        private JobTitleListPageComponents.JobTablePageComponent? JobTable
        {
            get 
            { 
                _jobTable ??= new JobTitleListPageComponents.JobTablePageComponent(FindElement(_jobTablePath));
                return _jobTable;
            }
        }
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
            return JobTable.GetListOfJobTitles();
        }
        public string GetJobDesctitionByJobTitle(string jobTitle)
        {
            return JobTable.GetJobDesctitionByJobTitle(jobTitle);
        }
        public void CheckCheckboxWithJobTitle(string title)
        {
            JobTable.CheckCheckboxWithJobTitle(title);
        }
        public JobTitleListPageObject DeleteSelected()
        {
            FindElement(_deleteSelectedButtonPath).Click();
            new JobTitleListPageComponents.DeletionPopUpWindowPageComponent(FindElement(_popUpWindowPath)).ClickDelete();
            return new JobTitleListPageObject(_webDriver);
        }
    }
}
