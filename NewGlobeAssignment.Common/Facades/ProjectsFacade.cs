using NewGlobeAssignment.Common.Models.UiModels;
using NewGlobeAssignment.Common.Pages;

namespace NewGlobeAssignment.Common.Facades
{
    public class ProjectsFacade
    {
        private readonly MainPage _mainPage;

        public ProjectsFacade()
        {
            _mainPage = new MainPage();
        }

        // public IEnumerable<Button> GetAllProjects()
        // {
        //     return _mainPage.Projects();
        // }

        public ProjectMainPageModel GetProjectInfoFromMainPageByName(string projectName)
        {
            return new ProjectMainPageModel
            {
                ProjectName = projectName,
                ProjectDescription = _mainPage.ProjectDescriptionByName(projectName).Text,
                ProjectKey = _mainPage.ProjectKeyByName(projectName).Text
            };
        }
    }
}
