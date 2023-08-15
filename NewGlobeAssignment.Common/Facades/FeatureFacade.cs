using NewGlobeAssignment.Common.Constants;
using NewGlobeAssignment.Common.Models.UiModels;

namespace NewGlobeAssignment.Common.Facades
{
    public class FeatureFacade : BaseFacade
    {
        #region Public Method

        public FeaturesPageModel<bool> GetFeatureInfoFromMainPageByName(string featureName)
        {
            return new FeaturesPageModel<bool>
            {
                FeatureName = featureName,
                Active = Convert.ToBoolean(FeaturePage.FeatureParameterStatusByNameAndParameter(featureName, FeatureParametersConstants.Active).Text),
                DefaultValue = Convert.ToBoolean(FeaturePage
                                                 .FeatureParameterStatusByNameAndParameter(featureName, FeatureParametersConstants.DefaultValue)
                                                 .Text),
                Type = FeaturePage.FeatureParameterStatusByNameAndParameter(featureName, FeatureParametersConstants.Type).Text
            };
        }

        #endregion
    }
}