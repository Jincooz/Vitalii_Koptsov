﻿namespace SeleniumHomeTask.PageObjects
{
    internal abstract class PageObject
    {
        protected readonly IWebDriver _webDriver;
        private string _pageUrl;
        public PageObject(IWebDriver webDriver, string pageUrl)
        {
            _pageUrl = pageUrl;
            _webDriver = webDriver;
        }
        public PageObject GoTo()
        {
            _webDriver.Navigate().GoToUrl(_pageUrl);
            return this;
        }
        public bool isValidToPageObject => _webDriver.Url != _pageUrl;
        protected IWebElement FindElement(By element)
        {
            if (isValidToPageObject)
            {
                WaitUntilObjectLoad(element);
                if (_webDriver.Url != _pageUrl)
                    throw new InvalidElementStateException("This is not " + _pageUrl + " current page is: " + _webDriver.Url);
            }
            try
            {
                return _webDriver.FindElement(element);
            }
            catch
            {
                WaitUntilObjectLoad(element);
                return _webDriver.FindElement(element);
            }
        }
        protected List<IWebElement> FindElements(By element)
        {
            if (isValidToPageObject)
            {
                throw new InvalidElementStateException("This is not " + _pageUrl + " current page is: " + _webDriver.Url);
            }
            try
            {
                List<IWebElement> result = _webDriver.FindElements(element).ToList();
                if (result.Count != 0)
                {
                    return result;
                }
            }
            catch
            {
            }
            WaitUntilObjectLoad(element);
            return _webDriver.FindElements(element).ToList();
        }
        private void WaitUntilObjectLoad(By element)
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            wait.Until(d => {
                try
                {
                    return d.FindElement(element).Enabled;
                }
                catch
                {
                    return false;
                }
            });
        }
        public void Close()
        {
            _webDriver.Quit();
        }
    }
}
