using NewGlobeAssignment.Common.Helpers;

namespace NewGlobeAssignment.Tests
{
    public abstract class ApiTestBase
    {
        #region Fields

        protected readonly HttpClient HttpClient;

        #endregion

        #region Constructors

        protected ApiTestBase()
        {
            HttpClient = HttpClientHelpers.GetHttpClient();
        }

        #endregion
    }
}