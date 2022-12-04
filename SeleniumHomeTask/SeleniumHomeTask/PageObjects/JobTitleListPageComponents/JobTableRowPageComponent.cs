namespace SeleniumHomeTask.PageObjects.JobTitleListPageObjectr
{
    internal class JobTableRowPageComponent : PageComponent
    {
        public IWebElement CheckBox => FindElement(By.XPath("div[1]/div"));
        public string JobTitle { get; }
        public string JobDescription { get; }
        public IWebElement DeleteButton => FindElements(By.ClassName("oxd-icon-button"))[0];
        public IWebElement EditButton => FindElements(By.ClassName("oxd-icon-button"))[1];
        public JobTableRowPageComponent(IWebElement row) : base(row)
        {
            JobTitle = FindElement(By.XPath("div[2]/div")).Text;
            JobDescription = FindElement(By.XPath("div[3]/div")).Text;
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
