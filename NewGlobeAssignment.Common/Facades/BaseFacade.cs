using NewGlobeAssignment.Common.Pages;

namespace NewGlobeAssignment.Common.Facades
{
    public abstract class BaseFacade
    {
        private protected readonly FeaturePage FeaturePage;
        private protected readonly MainPage MainPage;
        private protected readonly MicrosoftLoginPage LoginPage;

        public BaseFacade()
        {
            FeaturePage = new FeaturePage();
            MainPage = new MainPage();
            LoginPage = new MicrosoftLoginPage();
        }
    }
}
