using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Common.Helpers
{
    public class WebDriverHelper
    {
        private static readonly IWebDriver Driver;

        static WebDriverHelper()
        {
            Driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver() => Driver;
    }
}
