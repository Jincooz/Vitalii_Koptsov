namespace SeleniumHomeTask.PageObjects.JobTitleListPageComponents
{
    internal class JobTablePageComponent : PageComponent
    {
        private readonly By _tableRowsPath = By.ClassName("oxd-table-row");
        private List<JobTableRowPageComponent> _tableRows = new();
        public JobTablePageComponent(IWebElement webElement) : base(webElement)
        {
            var listOfRows = FindElements(_tableRowsPath);
            for (int i = 1; i < listOfRows.Count; i++)
            {
                _tableRows.Add(new JobTableRowPageComponent(listOfRows[i]));
            }
        }
        public List<string> GetListOfJobTitles()
        {
            return _tableRows.Select(x => x.JobTitle).ToList();
        }
        public string GetJobDesctitionByJobTitle(string jobTitle)
        {
            return _tableRows.Find(e => e.JobTitle == jobTitle).JobDescription;
        }
        public void CheckCheckboxWithJobTitle(string title)
        {
            _tableRows.Find(e => e.JobTitle == title).Check();
        }
    }
}
