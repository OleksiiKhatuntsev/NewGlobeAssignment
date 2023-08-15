using NewGlobeAssignment.Common.Pages;

namespace NewGlobeAssignment.Common.Facades
{
    public abstract class BaseFacade
    {
        #region Fields

        private protected readonly FeaturePage FeaturePage;
        private protected readonly MainPage MainPage;
        private protected readonly MicrosoftLoginPage LoginPage;

        #endregion

        #region Constructors

        protected BaseFacade()
        {
            FeaturePage = new FeaturePage();
            MainPage = new MainPage();
            LoginPage = new MicrosoftLoginPage();
        }

        #endregion
    }
}