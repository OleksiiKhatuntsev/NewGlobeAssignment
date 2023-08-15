using OpenQA.Selenium;
using NewGlobeAssignment.Common.Helpers;
using OpenQA.Selenium.Support.UI;

namespace NewGlobeAssignment.Common.Pages
{
    internal abstract class BasePage
    {
        #region Fields

        protected readonly IWebDriver Driver = WebDriverHelpers.GetDriver();

        #endregion

        #region Protected Method

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
            for (var i = 0; i < 10; i++)
            {
                try
                {
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds / 10));
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(ElementClickInterceptedException));
                    return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Driver.FindElement(by)));
                }
                catch { }
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

        #endregion
    }
}