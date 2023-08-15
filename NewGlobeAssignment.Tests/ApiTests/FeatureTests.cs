using FluentAssertions;
using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models.ApiModels.Feature;
using Newtonsoft.Json;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests.ApiTests
{
    internal class FeatureTests : ApiTestBase
    {
        [Test]
        public async Task Test1()
        {
            var response = await HttpClient.GetAsync($"{UrlConstants.ApiBaseUrl}{PathConstants.FeaturesStatusGet}");
            var result = await response.Content.ReadAsStringAsync();
            var requestBody = JsonConvert.DeserializeObject<List<FeatureApiGetModel>>(result);
            response.StatusCode.ToString().Should().Be("OK");

            requestBody.Should().NotBeNullOrEmpty();
            requestBody.Count.Should().BeGreaterThan(0);
        }
    }
}