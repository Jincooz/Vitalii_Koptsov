using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask.PageObjects
{
    internal class LoginPageObject : PageObject
    {
        private static readonly string _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        private IWebElement UsernameTextBox => FindElement(By.CssSelector("input.oxd-input[name=username]"));
        private IWebElement PasswordTextBox => FindElement(By.CssSelector("input.oxd-input[name=password]"));
        private IWebElement UsernameElement => FindElements(By.CssSelector("p.oxd-text"))[0];
        private IWebElement PasswordElement => FindElements(By.CssSelector("p.oxd-text"))[1];
        private IWebElement LoginButton => FindElement(By.ClassName("oxd-button"));
        public LoginPageObject(IWebDriver webDriver) : base(webDriver, _pageUrl) { }
        public void EnterUsername(string? username = null)
        {
            if (username == null)
            {
                username = UsernameElement.Text.Split(' ')[2];
            }
            UsernameTextBox.Clear();
            UsernameTextBox.SendKeys(username);
        }
        public void EnterPassword(string? password = null)
        {
            if (password == null)
            {
                password = PasswordElement.Text.Split(' ')[2];
            }
            PasswordTextBox.Clear();
            PasswordTextBox.SendKeys(password);
        }
        public DashboardPageObject ClickLogin()
        {
            LoginButton.Click();
            return new DashboardPageObject(_webDriver);
        }
    }
}
