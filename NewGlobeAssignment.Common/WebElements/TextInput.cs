using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.WebElements
{
    internal class TextInput : ElementBase
    {
        public TextInput(IWebElement element) : base(element) { }

        public void SendKeys(string text)
        {
            Element.SendKeys(text);
        }
    }
}
