using NewGlobeAssignment.Common.Pages;
using NewGlobeAssignment.Common.WebElements;

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

        public string GetProjectText()
        {
            return _mainPage.ProjectDescriptionByName("asd").GetText();
        }
    }
}
