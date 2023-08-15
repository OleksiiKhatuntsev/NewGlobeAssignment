using NewGlobeAssignment.Common.Facades;
using NewGlobeAssignment.Common.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Tests
{
    internal class UiTestBase
    {
        protected readonly IWebDriver ChromeDriver;
        protected readonly LoginFacade LoginFacade;
        protected readonly ProjectsFacade ProjectsFacade;

        public UiTestBase()
        {
            ChromeDriver = WebDriverHelper.GetDriver();
            LoginFacade = new LoginFacade();
            ProjectsFacade = new ProjectsFacade();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://softwaredeveloperintesttechnicaltest-test.bridgeinternationalacademies.com/projects");
            LoginFacade.LoginViaMs();
        }


        [Test]
        public void TestBase()
        {
            var a = ProjectsFacade.GetProjectText();
            var b = 0;
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ChromeDriver.Close();
        }
    }
}
