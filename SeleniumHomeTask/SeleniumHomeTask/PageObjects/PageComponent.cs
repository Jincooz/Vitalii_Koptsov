using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHomeTask.PageObjects
{
    internal abstract class PageComponent
    {
        protected readonly IWebElement _webElement;
        public PageComponent(IWebElement webElement)
        {
            _webElement = webElement;
        }
        public bool isEnabled()
        {
            try
            {
                return _webElement.Enabled;
            }
            catch
            {
                return false;
            }
        }
        protected IWebElement FindElement(By element)
        {
            return _webElement.FindElement(element);
        }
        protected List<IWebElement> FindElements(By element)
        {
            return _webElement.FindElements(element).ToList();
        }
    }
}
