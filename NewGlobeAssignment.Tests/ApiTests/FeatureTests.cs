using FluentAssertions;
using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models.ApiModels.Feature;
using Newtonsoft.Json;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests.ApiTests
{
    internal class FeatureTests : ApiTestBase
    {
        #region Public Method

        [Test]
        public async Task Test1()
        {
            var response = await HttpClient.GetAsync($"{UrlConstants.ApiBaseUrl}{PathConstants.FeaturesStatusGet}");
            string result = await response.Content.ReadAsStringAsync();
            var requestBody = JsonConvert.DeserializeObject<List<FeatureApiGetModel>>(result);
            response.StatusCode.ToString().Should().Be(RequestStatusConstants.Ok);
            requestBody.Should().NotBeNullOrEmpty();
            requestBody.Count.Should().BeGreaterThan(0);
        }

        #endregion
    }
}