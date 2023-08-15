using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NewGlobeAssignment.Common.WebElements
{
    internal class Button : ElementBase
    {
        public Button(IWebElement element) : base(element) { }

        public void Click(int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(ElementClickInterceptedException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Element)).Click();
        }
    }
}
