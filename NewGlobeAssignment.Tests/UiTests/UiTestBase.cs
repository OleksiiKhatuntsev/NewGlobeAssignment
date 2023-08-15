using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Facades;
using NewGlobeAssignment.Common.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Tests.UiTests
{
    internal class UiTestBase : ApiTestBase
    {
        protected readonly IWebDriver ChromeDriver;
        protected readonly LoginFacade LoginFacade;
        protected readonly ProjectsFacade ProjectsFacade;

        public UiTestBase()
        {
            ChromeDriver = WebDriverHelpers.GetDriver();
            LoginFacade = new LoginFacade();
            ProjectsFacade = new ProjectsFacade();
        }

        [OneTimeSetUp]
        public void OneTimeBaseSetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://softwaredeveloperintesttechnicaltest-test.bridgeinternationalacademies.com/projects");
            LoginFacade.LoginViaMs(
                Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.MicrosoftDefaultUserName, EnvironmentVariableTarget.User),
                Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.MicrosoftDefaultUserPassword, EnvironmentVariableTarget.User));
        }

        [SetUp]
        public void BaseSetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://softwaredeveloperintesttechnicaltest-test.bridgeinternationalacademies.com/projects");
        }

        [OneTimeTearDown]
        public void OneTimeBaseTearDown()
        {
            ChromeDriver.Close();
        }
    }
}
