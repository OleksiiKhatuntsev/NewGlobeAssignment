namespace NewGlobeAssignment.Common.Models.ApiModels.Feature
{
    public class FeatureApiGetModel
    {
        #region Properties

        public bool IsEnabled { get; set; }

        public string Key { get; set; }

        public string ProjectKey { get; set; }

        public string Type { get; set; }

        public bool Value { get; set; }

        #endregion
    }
}