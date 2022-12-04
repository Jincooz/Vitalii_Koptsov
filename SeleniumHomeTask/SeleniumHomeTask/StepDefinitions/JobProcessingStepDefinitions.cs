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
            currentPage = MbFactory.getJobTitleListPageObject(MbFactory.getDriver());
        }

        [Given(@"the admin click on Add button")]
        public void GivenTheAdminClickOnAddButton()
        {
            currentPage = (currentPage as JobTitleListPageObject).ClickAdd();
        }

        [Given(@"the admin enters '([^']*)' into Job Title field")]
        public void GivenTheAdminEntersIntoJobTitleField(string jobTitle)
        {
            (currentPage as SaveJobTitlePageObject).EnterJobTitle(jobTitle);
        }

        [Given(@"the admin enters '([^']*)' into Job Description field")]
        public void GivenTheAdminEntersIntoJobDescriptionField(string jobDescription)
        {
            (currentPage as SaveJobTitlePageObject).EnterJobDescription(jobDescription);
        }

        [Given(@"the admin enters '([^']*)' into Note field")]
        public void GivenTheAdminEntersIntoNoteField(string jobNote)
        {
            (currentPage as SaveJobTitlePageObject).EnterJobNote(jobNote);
        }

        [When(@"the admin click on Save button")]
        public void WhenTheAdminClickOnSaveButton()
        {
            currentPage = (currentPage as SaveJobTitlePageObject).ClickSave();
        }

        [Then(@"the admin is redirected to the admin viewJobTitleList page")]
        public void ThenTheAdminIsRedirectedToTheAdminViewJobTitleListPage()
        {
            Assert.That(currentPage.isValidToPageObject);
        }

        [Then(@"row with '([^']*)' as Job Title and with '([^']*)' as Job Description exist in table")]
        public void ThenRowWithAsJobTitleAndWithAsJobDescriptionExistInTable(string jobTitle, string jobDescription)
        {
            List<string> jobTitles = (currentPage as JobTitleListPageObject).GetListOfJobTitlesInTable();
            Assert.Contains(jobTitle, jobTitles);
            string jobDescriptionOnSite = (currentPage as JobTitleListPageObject).GetJobDesctitionByJobTitle(jobTitle);
            Assert.That(jobDescription.Contains(jobDescriptionOnSite.TrimStart()));
            currentPage.Close();
        }
        public void CreateJobWithJobTitle(string jobTitle)
        {
            GivenAAdminOnTheAdminViewJobTitleListPage();
            GivenTheAdminClickOnAddButton();
            GivenTheAdminEntersIntoJobTitleField(jobTitle);
            WhenTheAdminClickOnSaveButton();
            currentPage.Close();
        }
        [Given(@"Job Title '([^']*)' exist in table")]
        public void GivenJobTitleExistInTable(string jobTitle)
        {
            if (!(currentPage as JobTitleListPageObject).GetListOfJobTitlesInTable().Contains(jobTitle))
            {
                CreateJobWithJobTitle(jobTitle);
            }
        }

        [Given(@"the admin checks checkbox coresponding to '([^']*)' Job Title")]
        public void GivenTheAdminChecksCheckboxCorespondingToJobTitle(string jobTitle)
        {
            (currentPage as JobTitleListPageObject).CheckCheckboxWithJobTitle(jobTitle);
        }

        [Given(@"the admin scrolls up to top")]
        public void GivenTheAdminScrollsUpToTop()
        {
            currentPage.ScrollToTop();
        }

        [When(@"the admin clicks Delete Selected and ensure it in pop up window")]
        public void WhenTheAdminClicksDeleteSelected()
        {
            currentPage = (currentPage as JobTitleListPageObject).DeleteSelected();
        }

        [Then(@"row with '([^']*)' as Job Title don`t exist in table")]
        public void ThenRowWithAsJobTitleDonTExistInTable(string jobTitle)
        {
            List<string> jobTitles = (currentPage as JobTitleListPageObject).GetListOfJobTitlesInTable();
            Assert.That(!jobTitles.Contains(jobTitle));
            currentPage.Close();
        }
    }
}