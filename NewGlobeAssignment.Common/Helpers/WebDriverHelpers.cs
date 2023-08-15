using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Helpers
{
    public static class WebDriverHelpers
    {
        #region Fields

        private static readonly IWebDriver Driver;

        #endregion

        #region Constructors

        static WebDriverHelpers()
        {
            Driver = new ChromeDriver();
        }

        #endregion

        #region Public Method

        public static IWebDriver GetDriver()
        {
            return Driver;
        }

        #endregion
    }
}