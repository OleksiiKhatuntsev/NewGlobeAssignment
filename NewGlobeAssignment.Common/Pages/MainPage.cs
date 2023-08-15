using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class MainPage : BasePage
    {
        #region Public Method

        public IEnumerable<IWebElement> Projects()
        {
            return GetElements(By.XPath("//div[@class='card project-card']"));
        }

        public IWebElement ProjectDescriptionByName(string name)
        {
            return GetElement(
                By.XPath($"//*[contains(text(), '{name}')]//ancestor::div[@class = 'card project-card']//span[@class = 'card-description']"));
        }

        public IWebElement ProjectKeyByName(string name)
        {
            return GetElement(By.XPath(
                $"//*[contains(text(), '{name}')]//ancestor::div[@class = 'card project-card']//div[contains(@class, 'card-field')]//p[@class = 'field-value']"));
        }

        #endregion
    }
}