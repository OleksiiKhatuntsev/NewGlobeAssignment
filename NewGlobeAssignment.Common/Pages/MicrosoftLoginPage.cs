using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class MicrosoftLoginPage : BasePage
    {
        #region Internal Method

        internal IWebElement EmailField()
        {
            return GetElement(By.XPath("//input[@type='email']"));
        }

        internal IWebElement NextButton()
        {
            return GetClickableElement(By.Id("idSIButton9"));
        }

        internal IWebElement PasswordField()
        {
            return GetElement(By.XPath("//input[@type='password']"));
        }

        internal IWebElement SubmitButton()
        {
            return GetClickableElement(By.Id("idSIButton9"));
        }

        internal IWebElement NoStaySignedInButton()
        {
            return GetClickableElement(By.Id("idBtn_Back"));
        }

        #endregion
    }
}