using NUnit.Framework;
using SeleniumHomeTask.PageObjects;

namespace SeleniumHomeTask.StepDefinitions
{
    [Binding]
    public sealed class JobProcessingStepDefinitions
    {
        private PageObjects.PageObject? currentPage;
        [OneTimeSetUp]
        public void Init()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
        }
        [Given(@"a admin on the admin viewJobTitleList page")]
        public void GivenAAdminOnTheAdminViewJobTitleListPage()
        {
            currentPage = PageObjectStaticFabric.getJobTitleListPageObject(PageObjectStaticFabric.getDriver());
        }

        [Given(@"the admin click on Add button")]
        public void GivenTheAdminClickOnAddButton()
        {
            currentPage = (currentPage as JobTitleListPageObject).ClickAdd();
        }

        [Given(@"a job with '([^']*)' exist in table")]
        public void GivenAJobWithExistInTable(string jobTitle)
        {
            if (!(currentPage as JobTitleListPageObject).GetListOfJobTitlesInTable().Contains(jobTitle))
            {
                CreateJobWithJobTitle(jobTitle);
            }
        }

        [When(@"the admin saves new job with valid '([^']*)', '([^']*)' and '([^']*)'")]
        public void WhenTheAdminSavesNewJobWithValidAnd(string jobTitle, string jobDescription, string jobNote)
        {
            SaveJobTitlePageObject page = (currentPage as SaveJobTitlePageObject);
            page.EnterJobTitle(jobTitle);
            page.EnterJobDescription(jobDescription);
            page.EnterJobNote(jobNote);
            currentPage = page.ClickSave();
        }

        [When(@"the admin delete a job with '([^']*)' through Delete Selected button")]
        public void WhenTheAdminDeleteAJobWithThroughDeleteSelectedButton(string jobTitle)
        {
            (currentPage as JobTitleListPageObject).CheckCheckboxWithJobTitle(jobTitle);
            currentPage.ScrollToTop();
            currentPage = (currentPage as JobTitleListPageObject).DeleteSelected();
        }

        [Then(@"a job with '([^']*)' and with '([^']*)' exist in table")]
        public void ThenAJobWithAndWithExistInTable(string jobTitle, string jobDescription)
        {
            Assert.That(RowWithTitleExistInTable(jobTitle));
            string jobDescriptionOnSite = (currentPage as JobTitleListPageObject).GetJobDesctitionByJobTitle(jobTitle);
            Assert.That(jobDescription.Contains(jobDescriptionOnSite.TrimStart()));
            currentPage.Close();
        }

        [Then(@"row with '([^']*)' don`t exist in table")]
        public void ThenRowWithDonTExistInTable(string jobTitle)
        {
            Assert.That(!RowWithTitleExistInTable(jobTitle));
            currentPage.Close();
        }

        private bool RowWithTitleExistInTable(string jobTitle)
        {
            List<string> jobTitles = (currentPage as JobTitleListPageObject).GetListOfJobTitlesInTable();
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