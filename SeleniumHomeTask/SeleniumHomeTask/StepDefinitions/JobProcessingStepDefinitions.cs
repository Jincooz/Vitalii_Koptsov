using NUnit.Framework;
using SeleniumHomeTask.Drivers;
using SeleniumHomeTask.Features;
using SeleniumHomeTask.PageObjects;

namespace SeleniumHomeTask.StepDefinitions
{
    [Binding]
    public sealed class JobProcessingStepDefinitions
    {
        private JobTitleListPageObject? jobTitleList;
        private SaveJobTitlePageObject? saveJobTitleList;

        [Given(@"a admin on the admin viewJobTitleList page")]
        public void GivenAAdminOnTheAdminViewJobTitleListPage()
        {
            var loginPage = PageObjectStaticFabric.getLoginPageObject(Driver.Browser);
            loginPage.GoTo();
            loginPage.EnterUsername();
            loginPage.EnterPassword();
            DashboardPageObject dashboardPage = loginPage.ClickLogin();
            SystemUsersPageObject systemUsersPage = dashboardPage.GoToAdminPage();
            jobTitleList = systemUsersPage.OpenJobTitleList();
        }

        [Given(@"the admin click on Add button")]
        public void GivenTheAdminClickOnAddButton()
        {
            saveJobTitleList = jobTitleList.ClickAdd();
        }

        [Given(@"a job with (.*) exist in table")]
        public void GivenAJobWithExistInTable(string jobTitle)
        {
            if (!(jobTitleList).GetListOfJobTitlesInTable().Contains(jobTitle))
            {
                CreateJobWithJobTitle(jobTitle);
            }
        }

        [When(@"the admin saves new job with valid ([^,]*), (.*) and (.*)")]
        public void WhenTheAdminSavesNewJobWithValidAnd(string jobTitle, string jobDescription, string jobNote)
        {
            saveJobTitleList.EnterJobTitle(jobTitle);
            saveJobTitleList.EnterJobDescription(jobDescription);
            saveJobTitleList.EnterJobNote(jobNote);
            jobTitleList = saveJobTitleList.ClickSave();
        }

        [When(@"the admin delete a job with ([^']*) through Delete Selected button")]
        public void WhenTheAdminDeleteAJobWithThroughDeleteSelectedButton(string jobTitle)
        {
            jobTitleList.CheckCheckboxWithJobTitle(jobTitle);
            jobTitleList.ScrollToTop();
            jobTitleList = jobTitleList.DeleteSelected();
        }

        [Then(@"a job with (.*) and with (.*) exist in table")]
        public void ThenAJobWithAndWithExistInTable(string jobTitle, string jobDescription)
        {
            Assert.That(RowWithTitleExistInTable(jobTitle));
            string jobDescriptionOnSite = jobTitleList.GetJobDesctitionByJobTitle(jobTitle);
            Assert.That(jobDescription.Contains(jobDescriptionOnSite.TrimStart()));
        }

        [Then(@"row with (.*) don`t exist in table")]
        public void ThenRowWithDonTExistInTable(string jobTitle)
        {
            Assert.That(!RowWithTitleExistInTable(jobTitle));
        }

        private bool RowWithTitleExistInTable(string jobTitle)
        {
            List<string> jobTitles = jobTitleList.GetListOfJobTitlesInTable();
            return jobTitles.Contains(jobTitle);
        }

        private void CreateJobWithJobTitle(string jobTitle)
        {
            GivenAAdminOnTheAdminViewJobTitleListPage();
            GivenTheAdminClickOnAddButton();
            WhenTheAdminSavesNewJobWithValidAnd(jobTitle, "", "");
        }
    }
}