using OpenQA.Selenium;
using NewGlobeAssignment.Common.Helpers;
using OpenQA.Selenium.Support.UI;


namespace NewGlobeAssignment.Common.Pages
{
    internal class BasePage
    {
        protected readonly IWebDriver Driver = WebDriverHelpers.GetDriver();

        protected IWebElement GetElement(By by)
        {
            try
            {
                return WaitHelpers.ForCondition(() => Driver.FindElement(by) != null, () => Driver.FindElement(by));
            }
            catch
            {
                return null;
            }
        }

        protected IWebElement GetClickableElement(By by, int timeoutInSeconds = 10)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds / 10));
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(ElementClickInterceptedException));
                    return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Driver.FindElement(by)));
                }
                catch
                { }
            }

            return null;
        }

        protected IEnumerable<IWebElement> GetElements(By by)
        {
            try
            {
                return WaitHelpers.ForCondition(() => Driver.FindElements(by).Count > 0, () => Driver.FindElements(by));
            }
            catch
            {
                return new List<IWebElement>();
            }
        }
    }
}
