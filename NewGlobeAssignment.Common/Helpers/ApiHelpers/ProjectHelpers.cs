using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models.ApiModels.Projects;
using Newtonsoft.Json;
using System.Text;

namespace NewGlobeAssignment.Common.Helpers.ApiHelpers
{
    public static class ProjectHelpers
    {
        private static readonly HttpClient HttpClient;

        static ProjectHelpers()
        {
            HttpClient = HttpClientHelpers.GetHttpClient();
        }

        public static async Task<ProjectApiModel?> PostNewProject(string name = "Default name", string description = "Default description", string changedBy = "Default userName")
        {
            var newProjectModel = new SaveProjectApiModel
            {
                ChangedBy = "changedBy",
                Description = "description",
                Key = Guid.NewGuid().ToString(),
                Name = "name"
            };

            var response = await HttpClient.PostAsync($"{UrlConstants.TestSiteUrl}/projects", new StringContent(JsonConvert.SerializeObject(newProjectModel), Encoding.UTF8, "application/json"));
            return JsonConvert.DeserializeObject<ProjectApiModel>(await response.Content.ReadAsStringAsync());
        }

        public static async Task<ProjectApiModel?> GetProjectByKey(string key)
        {
            return JsonConvert.DeserializeObject<ProjectApiModel>(await (await HttpClient.GetAsync($"{UrlConstants.TestSiteUrl}/projects/{key}")).Content.ReadAsStringAsync());
        }

        public static async Task DeleteProjectByKey(string key)
        {
            await HttpClient.DeleteAsync($"{UrlConstants.TestSiteUrl}/projects/{key}");
        }
    }
}
