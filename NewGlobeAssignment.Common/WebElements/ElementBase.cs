using NewGlobeAssignment.Common.Helpers;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.WebElements
{
    internal class ElementBase
    {
        protected readonly IWebElement Element;
        protected readonly IWebDriver Driver;

        public ElementBase(IWebElement element)
        {
            Element = element;
            Driver = WebDriverHelper.GetDriver();
        }
    }
}
