using FluentAssertions;
using NewGlobeAssignment.Common.Helpers.ApiHelpers;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests.UiTests
{
    internal class ProjectTests : UiTestBase
    {
        [Test]
        public async Task GetProjectTest()
        {
            var projectFromApi = await ProjectHelpers.GetProjectByKey(Project.Key);

            var projectByName = ProjectsFacade.GetProjectInfoFromMainPageByName(projectFromApi.Name);

            projectByName.ProjectName.Should().Be(projectFromApi.Name);
            projectByName.ProjectDescription.Should().Be(projectByName.ProjectDescription);
            projectByName.ProjectKey.Should().Be(projectByName.ProjectKey);
        }
    }
}
