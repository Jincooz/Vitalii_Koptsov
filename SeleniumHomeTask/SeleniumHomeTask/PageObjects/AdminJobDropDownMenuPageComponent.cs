using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask.PageObjects
{
    internal class AdminJobDropDownMenuPageComponent : PageComponent
    {
        private IWebElement JobTitlesReference => FindElement(By.ClassName("oxd-topbar-body-nav-tab-link"));
        public AdminJobDropDownMenuPageComponent(IWebElement webElement) : base(webElement) { }
        public void OpenJobTitleList()
        {
            JobTitlesReference.Click();
        }
    }
}
