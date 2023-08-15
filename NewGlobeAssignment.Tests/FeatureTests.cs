using FluentAssertions;
using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models.Feature;
using Newtonsoft.Json;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests
{
    internal class FeatureTests : ApiTestBase
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async Task Test1()
        {
            var response = await HttpClient.GetAsync($"{UrlConstants.TestSiteUrl}{ApiPathConstants.FeaturesStatusGet}");
            var result = await response.Content.ReadAsStringAsync();
            var requestBody = JsonConvert.DeserializeObject<List<FeatureApiGetModel>>(result);
            response.StatusCode.ToString().Should().Be("OK");

            requestBody.Should().NotBeNullOrEmpty();
            requestBody.Count.Should().BeGreaterThan(0);
        }
    }
}