using NewGlobeAssignment.Common.Helpers;

namespace NewGlobeAssignment.Tests
{
    public abstract class ApiTestBase
    {
        protected readonly HttpClient HttpClient;

        protected ApiTestBase()
        {
            HttpClient = HttpClientHelpers.GetHttpClient();
        }
    }
}
