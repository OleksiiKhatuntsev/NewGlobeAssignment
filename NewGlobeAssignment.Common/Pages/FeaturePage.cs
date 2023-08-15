using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class FeaturePage : BasePage
    {
        public IEnumerable<IWebElement> Features() => GetElements(By.XPath("//div[@class='card feature-card']"));

        public IWebElement FeatureParameterStatusByNameAndParameter(string name, string parameter) =>
            GetElement(By.XPath(
                $"//span[contains(text(), '{name}')]" +
                "//ancestor::div[@class='content feature-card-container']" +
                $"//p[contains(text(), '{parameter}')]/following-sibling::p"));
    }
}
