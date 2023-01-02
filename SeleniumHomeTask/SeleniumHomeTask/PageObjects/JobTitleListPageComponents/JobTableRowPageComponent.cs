namespace SeleniumHomeTask.PageObjects.JobTitleListPageComponents
{
    internal class JobTableRowPageComponent : PageComponent
    {
        private readonly By _jobTitlePath = By.XPath("div[2]/div");
        private readonly By _jobDescriptionPath = By.XPath("div[3]/div");
        private readonly By _checkBoxPath = By.XPath("div[1]/div");
        private readonly By _buttonsPath = By.ClassName("oxd-icon-button");
        public string JobTitle { get; }
        public string JobDescription { get; }
        public IWebElement CheckBox => FindElement(_checkBoxPath);
        public IWebElement DeleteButton => FindElements(_buttonsPath)[0];
        public IWebElement EditButton => FindElements(_buttonsPath)[1];
        public JobTableRowPageComponent(IWebElement row) : base(row)
        {
            JobTitle = FindElement(_jobTitlePath).Text;
            JobDescription = FindElement(_jobDescriptionPath).Text;
        }
        public bool IsChecked()
        {
            return CheckBox.Selected;
        }
        public void Check()
        {
            if(!IsChecked())
            {
                CheckBox.Click();
            }
        }
        public void Uncheck() 
        {
            if(IsChecked()) 
            { 
                CheckBox.Click();
            }        
        }
    }
}
