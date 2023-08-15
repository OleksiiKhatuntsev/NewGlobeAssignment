using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Helpers
{
    public class WebDriverHelpers
    {
        private static readonly IWebDriver Driver;

        static WebDriverHelpers()
        {
            Driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver() => Driver;
    }
}
