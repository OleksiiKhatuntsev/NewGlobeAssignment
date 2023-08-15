using FluentAssertions;
using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Helpers.ApiHelpers;
using NewGlobeAssignment.Common.Models.ApiModels.Feature;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests.UiTests
{
    public class FeatureTests : UiTestBase
    {
        private FeatureApiModel<bool> booleanFeature;
        private FeatureApiModel<string> stringFeature;

        // private VariationApiModel booleanFeatureVariations;
        // private VariationApiModel stringFeatureVariations;

        [SetUp]
        public async Task SetUp()
        {
            booleanFeature = await FeatureHelpers.CreateEmptyBooleanFeatureForProject(Project.Key, true, true, "asd", "asd", "asd", new List<VariationApiModel>());
            stringFeature = await FeatureHelpers.CreateEmptyStringFeatureForProject(Project.Key, true, "Default", "asd", "asd", "asd", new List<VariationApiModel>());
            // booleanFeatureVariations = await FeatureHelpers.AddVariationToFeatureForProject(Project.Key, booleanFeature.Key, "default", new List<TargetApiModel>(), true); 
            // stringFeatureVariations = await FeatureHelpers.AddVariationToFeatureForProject(Project.Key, stringFeature.Key, "default", new List<TargetApiModel>(), true);
            
            Driver.Navigate().GoToUrl($"{UrlConstants.TestBaseUrl}{PathConstants.Projects}/{Project.Key}{PathConstants.Features}");
        }


        [Test]
        public void GetFeatureMainInformation()
        {
            var booleanFeatureFromWeb = FeatureFacade.GetFeatureInfoFromMainPageByName(booleanFeature.Name);

            booleanFeatureFromWeb.Type.Should().Be("Boolean");
            booleanFeatureFromWeb.DefaultValue.Should().BeTrue();
            booleanFeatureFromWeb.Active.Should().BeTrue();
        }
    }
}
