using FluentAssertions;
using NewGlobeAssignment.Common.Helpers.ApiHelpers;
using NewGlobeAssignment.Common.Models.ApiModels.Projects;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests.UiTests
{
    internal class ProjectTests : UiTestBase
    {

        private readonly string _projectName = "Project" + DateTime.Now;
        private readonly string _projectDescription = "Description" + DateTime.Now;
        private readonly string _projectChangedBy = "ChangedBy" + DateTime.Now;
        private ProjectApiModel? _project;

        [SetUp]
        public async Task SetUp()
        {
            _project = await ProjectHelpers.PostNewProject(_projectName, _projectDescription, _projectChangedBy);
            if (_project == null)
            {
                throw new Exception("Failed to create the project by an API");
            }
        }

        [TearDown]
        public async Task TearDown()
        {
            await ProjectHelpers.DeleteProjectByKey(_project.Key);
        }

        [Test]
        public async Task GetProjectTest()
        {
            var projectFromApi = await ProjectHelpers.GetProjectByKey(_project.Key);

            var projectByName = ProjectsFacade.GetProjectInfoFromMainPageByName(projectFromApi.Name);

            projectByName.ProjectName.Should().Be(projectFromApi.Name);
            projectByName.ProjectDescription.Should().Be(projectByName.ProjectDescription);
            projectByName.ProjectKey.Should().Be(projectByName.ProjectKey);
        }
    }
}
