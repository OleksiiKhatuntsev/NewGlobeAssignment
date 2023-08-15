using System.Net.Http.Headers;
using System.Text;
using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models;

namespace NewGlobeAssignment.Common.Helpers
{
    public static class HttpClientHeaderHelpers
    {
        public static AuthenticationHeaderValue GetBasicAuthorizationHeader(UserCredentials userCredentials) => new (AuthenticationSchemesConstants.BasicScheme,
            Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userCredentials.UserName}:{userCredentials.Password}")));

        public static void SetXRequestIdHeader(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add(HeadersConstants.XRequestId, Guid.NewGuid().ToString());
        }

        public static void SetUserAgentHeader(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add(HeadersConstants.UserAgent, "Application-Name/1.0.0 (Operating System Name 1.0.0)");
        }

        public static void SetAllRequiredHeadersExceptAuthentication(HttpClient httpClient)
        {
            SetXRequestIdHeader(httpClient);
            SetUserAgentHeader(httpClient);
        }
        
    }
}
