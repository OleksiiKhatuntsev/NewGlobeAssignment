using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models;

namespace NewGlobeAssignment.Common.Helpers
{
    public static class HttpClientHelpers
    {
        #region Fields

        private static readonly HttpClient HttpClient;

        #endregion

        #region Constructors

        static HttpClientHelpers()
        {
            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Authorization = HttpClientHeaderHelpers.GetBasicAuthorizationHeader(
                new UserCredentials(
                    Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.BasicDefaultUserName, EnvironmentVariableTarget.User),
                    Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.BasicDefaultUserPassword,
                        EnvironmentVariableTarget.User)));

            HttpClientHeaderHelpers.SetAllRequiredHeadersExceptAuthentication(HttpClient);
        }

        #endregion

        #region Public Method

        public static HttpClient GetHttpClient()
        {
            return HttpClient;
        }

        #endregion
    }
}