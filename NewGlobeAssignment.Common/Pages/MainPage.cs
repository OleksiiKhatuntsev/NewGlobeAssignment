using NewGlobeAssignment.Common.WebElements;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class MainPage : BasePage
    {
        // todo should be rewritten with generics, using the ElementBase as genericType
        public IEnumerable<Button> Projects()
        {
            var elements = GetElements(By.XPath("//div[@class='card project-card']"));
            return elements.Select(webElement => new Button(webElement)).ToList();
        }

        public Label ProjectDescriptionByName(string name) => new(GetElement(By.XPath("//*[text() = 'Project Name')]")));
    }
}
