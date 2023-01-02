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
