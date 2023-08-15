using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models.ApiModels.Feature;
using Newtonsoft.Json;

namespace NewGlobeAssignment.Common.Helpers.ApiHelpers
{
    public static class FeatureHelpers
    {
        #region Fields

        private static readonly HttpClient HttpClient;

        #endregion

        #region Constructors

        static FeatureHelpers()
        {
            HttpClient = HttpClientHelpers.GetHttpClient();
        }

        #endregion

        #region Public Method

        public static async Task<FeatureApiModel<bool>> CreateEmptyBooleanFeatureForProject(string projectKey,
                                                                                            bool active,
                                                                                            bool defaultValue,
                                                                                            string name,
                                                                                            string description,
                                                                                            string changedBy,
                                                                                            List<VariationApiModel> variations = default)
        {
            var saveFeatureModel = new SaveFeatureApiModel<bool>
            {
                Active = active,
                ChangedBy = changedBy,
                DefaultValue = defaultValue,
                Description = description,
                Key = Guid.NewGuid().ToString(),
                Name = name,
                Type = FeatureTypeConstants.Boolean,
                Variations = variations
            };

            var response = await HttpClient.PostAsync($"{UrlConstants.ApiBaseUrl}{PathConstants.Projects}/{projectKey}{PathConstants.Features}",
                JsonHelpers.GetStringContentForPostRequest(saveFeatureModel));

            return JsonConvert.DeserializeObject<FeatureApiModel<bool>>(await response.Content.ReadAsStringAsync());
        }

        public static async Task<FeatureApiModel<string>> CreateEmptyStringFeatureForProject(string projectKey,
                                                                                             bool active,
                                                                                             string defaultValue,
                                                                                             string name,
                                                                                             string description,
                                                                                             string changedBy,
                                                                                             List<VariationApiModel> variations = default)
        {
            var saveFeatureModel = new SaveFeatureApiModel<string>
            {
                Active = active,
                ChangedBy = changedBy,
                DefaultValue = defaultValue,
                Description = description,
                Key = Guid.NewGuid().ToString(),
                Name = name,
                Type = FeatureTypeConstants.String,
                Variations = variations
            };

            var response = await HttpClient.PostAsync($"{UrlConstants.ApiBaseUrl}{PathConstants.Projects}/{projectKey}{PathConstants.Features}",
                JsonHelpers.GetStringContentForPostRequest(saveFeatureModel));

            return JsonConvert.DeserializeObject<FeatureApiModel<string>>(await response.Content.ReadAsStringAsync());
        }

        //todo move to another class
        public static async Task<VariationApiModel> AddVariationToFeatureForProject(string projectKey,
                                                                                    string featureKey,
                                                                                    string variationKey,
                                                                                    List<TargetApiModel> targets,
                                                                                    bool value,
                                                                                    string name = default)
        {
            var variationModel = new VariationApiModel
            {
                Key = variationKey,
                Name = name,
                Targets = targets,
                Value = value
            };

            var response = await HttpClient.PostAsync(
                $"{UrlConstants.ApiBaseUrl}{PathConstants.Projects}/{projectKey}{PathConstants.Features}/{featureKey}/variations",
                JsonHelpers.GetStringContentForPostRequest(variationModel));

            return JsonConvert.DeserializeObject<VariationApiModel>(await response.Content.ReadAsStringAsync());
        }

        #endregion
    }
}