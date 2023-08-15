using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Helpers;
using NewGlobeAssignment.Common.Models;
using System.Net.Http;
using NUnit.Framework;

namespace NewGlobeAssignment.Tests
{
    internal class ApiTestBase
    {
        protected readonly HttpClient HttpClient;

        public ApiTestBase()
        {
            HttpClient = new HttpClient();
        }

        [OneTimeSetUp]
        public void SetUp()
        {
            HttpClient.DefaultRequestHeaders.Authorization = HttpClientHeaderHelpers.GetBasicAuthorizationHeader(
                new UserCredentials(UserCredentialsConstants.BasicDefaultUserName, UserCredentialsConstants.BasicDefaultUserPassword));

            HttpClientHeaderHelpers.SetAllRequiredHeadersExceptAuthentication(HttpClient);
        }
    }
}
