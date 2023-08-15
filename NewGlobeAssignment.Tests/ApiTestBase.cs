using NewGlobeAssignment.Common.Helpers;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests
{
    internal class ApiTestBase
    {
        protected readonly HttpClient HttpClient;

        public ApiTestBase()
        {
            HttpClient = HttpClientHelpers.GetHttpClient();
        }

        [OneTimeSetUp]
        public void ApiSetUp()
        {
            
        }
    }
}
