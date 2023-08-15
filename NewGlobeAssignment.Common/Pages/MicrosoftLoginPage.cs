using NewGlobeAssignment.Common.WebElements;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Pages
{
    internal class MicrosoftLoginPage : BasePage
    {
        internal TextInput EmailField() => new (GetElement(By.XPath("//input[@type='email']")));
        
        internal Button NextButton() => new (GetElement(By.Id("idSIButton9")));

        internal TextInput PasswordField() => new (GetElement(By.XPath("//input[@type='password']")));

        internal Button SubmitButton() => new (GetElement(By.Id("idSIButton9")));

        internal Button NoStaySignedInButton() => new (GetElement(By.Id("idBtn_Back")));
    }
}
