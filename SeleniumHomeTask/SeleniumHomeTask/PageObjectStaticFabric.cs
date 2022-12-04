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
        public static PageObjects.JobTitleListPageObject getJobTitleListPageObject(IWebDriver _driver )
        {
            return getSystemUsersPageObject(_driver).OpenJobTitleList();
        }
        public static PageObjects.SystemUsersPageObject getSystemUsersPageObject(IWebDriver _driver)
        {
            return getDashboardPageObject(_driver).GoToAdminPage();
        }
        public static PageObjects.DashboardPageObject getDashboardPageObject(IWebDriver _driver)
        {
            var loginPage = getLoginPageObject(_driver);
            loginPage.EnterUsername();
            loginPage.EnterPassword();
            return loginPage.ClickLogin();
        }
        public static PageObjects.LoginPageObject getLoginPageObject(IWebDriver _driver)
        {
            PageObject loginPage = new LoginPageObject(_driver);
            return (LoginPageObject)(loginPage.GoTo());
        }
        public static IWebDriver getDriver()
        {
            return new ChromeDriver();
        }
    }
}
