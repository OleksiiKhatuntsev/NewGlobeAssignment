namespace NewGlobeAssignment.Common.Facades
{
    public class LoginFacade : BaseFacade
    {
        #region Public Method

        public void LoginViaMs(string? userEmail, string? userPassword)
        {
            LoginPage.EmailField().SendKeys(userEmail);
            LoginPage.NextButton().Click();
            LoginPage.PasswordField().SendKeys(userPassword);
            LoginPage.SubmitButton().Click();
            LoginPage.NoStaySignedInButton().Click();
        }

        #endregion
    }
}