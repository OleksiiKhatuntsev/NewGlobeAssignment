using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class FeaturePage : BasePage
    {
        #region Public Method

        public IEnumerable<IWebElement> Features()
        {
            return GetElements(By.XPath("//div[@class='card feature-card']"));
        }

        public IWebElement FeatureParameterStatusByNameAndParameter(string name, string parameter)
        {
            return GetElement(By.XPath($"//span[contains(text(), '{name}')]" + "//ancestor::div[@class='content feature-card-container']" +
                                       $"//p[contains(text(), '{parameter}')]/following-sibling::p"));
        }

        #endregion
    }
}