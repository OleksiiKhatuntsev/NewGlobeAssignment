using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models;

namespace NewGlobeAssignment.Common.Helpers
{
    public static class HttpClientHelpers
    {
        private static readonly HttpClient HttpClient;

        static HttpClientHelpers()
        {
            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Authorization = HttpClientHeaderHelpers.GetBasicAuthorizationHeader(
                new UserCredentials(Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.BasicDefaultUserName, EnvironmentVariableTarget.User),
                    Environment.GetEnvironmentVariable(UserCredentialsEnvironmentConstants.BasicDefaultUserPassword, EnvironmentVariableTarget.User)));

            HttpClientHeaderHelpers.SetAllRequiredHeadersExceptAuthentication(HttpClient);
        }

        public static HttpClient GetHttpClient() => HttpClient;
    }
}
