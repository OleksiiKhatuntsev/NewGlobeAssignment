using NewGlobeAssignment.Common.Helpers;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Facades
{
    public abstract class BaseFacade
    {
        private IWebDriver _driver;

        public BaseFacade()
        {
            _driver = WebDriverHelpers.GetDriver();
        }
    }
}
