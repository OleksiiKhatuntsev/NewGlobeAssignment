using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.WebElements
{
    internal class Label : ElementBase
    {
        public Label(IWebElement element) : base(element) { }

        public string GetText(int timeoutInSeconds = 10)
        {
            return Element.Text;
        }
    }
}
