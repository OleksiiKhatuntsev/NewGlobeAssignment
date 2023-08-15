using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Pages;

namespace NewGlobeAssignment.Common.Facades
{
    public class LoginFacade
    {
        private readonly MicrosoftLoginPage _loginPage;

        public LoginFacade()
        {
            _loginPage = new MicrosoftLoginPage();
        }

        public void LoginViaMs(string userEmail = UserCredentialsConstants.MicrosoftDefaultUserName,
                               string userPassword = UserCredentialsConstants.MicrosoftDefaultUserPassword)
        {
            _loginPage.EmailField().SendKeys(userEmail);
            _loginPage.NextButton().Click();
            _loginPage.PasswordField().SendKeys(userPassword);
            _loginPage.SubmitButton().Click();
            _loginPage.NoStaySignedInButton().Click();
        }
    }
}
