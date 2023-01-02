namespace SeleniumHomeTask.PageObjects
{
    internal class LoginPageObject : PageObject
    {
        private readonly By _usernameTextBoxPath = By.CssSelector("input.oxd-input[name=username]");
        private readonly By _passwordTextBoxPath = By.CssSelector("input.oxd-input[name=password]");
        private readonly By _autorizationDataPath = By.CssSelector("p.oxd-text");
        private readonly By _loginButtonPath = By.ClassName("oxd-button");
        public LoginPageObject(IWebDriver webDriver) : base(webDriver)
        {
            _pageUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        }
        public void EnterUsername(string? username = null)
        {
            if (username == null)
            {
                IWebElement usernameElement = FindElements(_autorizationDataPath)[0];
                username = usernameElement.Text.Split(' ')[2];
            }
            IWebElement usernameTextBox = FindElement(_usernameTextBoxPath);
            usernameTextBox.Clear();
            usernameTextBox.SendKeys(username);
        }
        public void EnterPassword(string? password = null)
        {
            if (password == null)
            {
                IWebElement passwordElement = FindElements(_autorizationDataPath)[1];
                password = passwordElement.Text.Split(' ')[2];
            }
            IWebElement passwordTextBox = FindElement(_passwordTextBoxPath);
            passwordTextBox.Clear();
            passwordTextBox.SendKeys(password);
        }
        public DashboardPageObject ClickLogin()
        {
            FindElement(_loginButtonPath).Click();
            return new DashboardPageObject(_webDriver);
        }
    }
}
