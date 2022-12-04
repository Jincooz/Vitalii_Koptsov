﻿namespace SeleniumHomeTask.PageObjects.JobTitleListPageComponents
{
    internal class JobTablePageComponent : PageComponent
    {
        private List<JobTableRowPageComponent> TableRows { get; set; }
        public JobTablePageComponent(IWebElement webElement) : base(webElement)
        {
            TableRows = new();
            var listOfRows = FindElements(By.ClassName("oxd-table-row"));
            for (int i = 1; i < listOfRows.Count; i++)
            {
                TableRows.Add(new JobTableRowPageComponent(listOfRows[i]));
            }
        }
        public List<string> GetListOfJobTitles()
        {
            return TableRows.Select(x => x.JobTitle).ToList();
        }
        public string GetJobDesctitionByJobTitle(string jobTitle)
        {
            return TableRows.Find(e => e.JobTitle == jobTitle).JobDescription;
        }
        public void CheckCheckboxWithJobTitle(string title)
        {
            TableRows.Find(e => e.JobTitle == title).Check();
        }
    }
}
