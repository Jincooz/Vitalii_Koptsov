using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using SeleniumHomeTask.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask
{
    internal class PageObjectStaticFabric
    {
        public static LoginPageObject getLoginPageObject(IWebDriver _driver)
        {
            return new LoginPageObject(_driver);
        }   

    }
}
