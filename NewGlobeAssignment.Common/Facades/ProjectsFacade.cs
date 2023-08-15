using NewGlobeAssignment.Common.Models.UiModels;

namespace NewGlobeAssignment.Common.Facades
{
    public class ProjectsFacade : BaseFacade
    {
        #region Public Method

        public ProjectMainPageModel GetProjectInfoFromMainPageByName(string projectName)
        {
            return new ProjectMainPageModel
            {
                ProjectName = projectName,
                ProjectDescription = MainPage.ProjectDescriptionByName(projectName).Text,
                ProjectKey = MainPage.ProjectKeyByName(projectName).Text
            };
        }

        #endregion
    }
}