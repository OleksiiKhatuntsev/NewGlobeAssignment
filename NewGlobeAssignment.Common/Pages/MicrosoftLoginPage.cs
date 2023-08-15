using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class MicrosoftLoginPage : BasePage
    {
        internal IWebElement EmailField() => GetElement(By.XPath("//input[@type='email']"));
        
        internal IWebElement NextButton() => GetClickableElement(By.Id("idSIButton9"));

        internal IWebElement PasswordField() => GetElement(By.XPath("//input[@type='password']"));

        internal IWebElement SubmitButton() => GetClickableElement(By.Id("idSIButton9"));

        internal IWebElement NoStaySignedInButton() => GetClickableElement(By.Id("idBtn_Back"));
    }
}
