using Newtonsoft.Json;
using System.Text;
using NewGlobeAssignment.Common.Constants;

namespace NewGlobeAssignment.Common.Helpers
{
    public static class JsonHelpers
    {
        #region Public Method

        // todo add dynamic support for the different encodings, and media types
        public static StringContent GetStringContentForPostRequest<T>(T model)
        {
            return new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, MediaTypeConstants.ApplicationTypeJson);
        }

        #endregion
    }
}