using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask.PageObjects
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
        public void Close()
        {
            _webDriver.Quit();
        }
    }
}
