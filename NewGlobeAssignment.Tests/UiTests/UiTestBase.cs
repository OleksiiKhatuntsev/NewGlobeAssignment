using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Facades;
using NewGlobeAssignment.Common.Helpers;
using NewGlobeAssignment.Common.Helpers.ApiHelpers;
using NewGlobeAssignment.Common.Models.ApiModels.Projects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NewGlobeAssignment.Tests.UiTests
{
    public class UiTestBase : ApiTestBase
    {
        protected readonly IWebDriver Driver;
        protected readonly LoginFacade LoginFacade;
        protected readonly ProjectsFacade ProjectsFacade;
        protected readonly FeatureFacade FeatureFacade;

        protected readonly string ProjectName = "Project" + DateTime.Now;
        protected readonly string ProjectDescription = "Description" + DateTime.Now;
        protected readonly string ProjectChangedBy = "ChangedBy" + DateTime.Now;
        protected ProjectApiModel? Project;

        public UiTestBase()
        {
            Driver = WebDriverHelpers.GetDriver();
            LoginFacade = new LoginFacade();
            ProjectsFacade = new ProjectsFacade();
            FeatureFacade = new FeatureFacade();
        }

        [OneTimeSetUp]
        public void OneTimeBaseSetUp()
        {
            Driver.Navigate().GoToUrl($"{UrlConstants.TestBaseUrl}{PathConstants.Projects}");
            LoginFacade.LoginViaMs(
                Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.MicrosoftDefaultUserName, EnvironmentVariableTarget.User),
                Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.MicrosoftDefaultUserPassword, EnvironmentVariableTarget.User));
        }

        [SetUp]
        public async Task BaseSetUp()
        {
            Driver.Navigate().GoToUrl($"{UrlConstants.TestBaseUrl}{PathConstants.Projects}");
            Project = await ProjectHelpers.PostNewProject(ProjectName, ProjectDescription, ProjectChangedBy);
            if (Project == null)
            {
                throw new Exception("Failed to create the project by an API");
            }
        }

        [TearDown]
        public async Task BaseTearDown()
        {
            await ProjectHelpers.DeleteProjectByKey(Project.Key);
        }

        [OneTimeTearDown]
        public void OneTimeBaseTearDown()
        {
            Driver.Close();
        }
    }
}
