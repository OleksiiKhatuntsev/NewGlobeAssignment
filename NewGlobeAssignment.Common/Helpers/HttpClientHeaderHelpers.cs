using System.Net.Http.Headers;
using System.Text;
using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models;

namespace NewGlobeAssignment.Common.Helpers
{
    public static class HttpClientHeaderHelpers
    {
        #region Public Method

        public static AuthenticationHeaderValue GetBasicAuthorizationHeader(UserCredentials userCredentials)
        {
            return new(AuthenticationSchemesConstants.BasicScheme,
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userCredentials.UserName}:{userCredentials.Password}")));
        }

        public static void SetXRequestIdHeader(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add(HeadersConstants.XRequestId, Guid.NewGuid().ToString());
        }

        public static void SetUserAgentHeader(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add(HeadersConstants.UserAgent, Environment.OSVersion.ToString());
        }

        public static void SetAllRequiredHeadersExceptAuthentication(HttpClient httpClient)
        {
            SetXRequestIdHeader(httpClient);
            SetUserAgentHeader(httpClient);
        }

        #endregion
    }
}