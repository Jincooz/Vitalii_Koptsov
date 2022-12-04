using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask.PageObjects
{
    internal class JobTitleListPageObject : PageObject
    {
        private static readonly string _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewJobTitleList";
        private IWebElement AddButton => FindElement(By.ClassName("oxd-button"));
        public JobTitleListPageObject(IWebDriver webDriver) : base(webDriver, _pageUrl) { }
        public SaveJobTitlePageObject ClickAdd()
        {
            AddButton.Click();
            return new SaveJobTitlePageObject(_webDriver);
        }
    }
}
