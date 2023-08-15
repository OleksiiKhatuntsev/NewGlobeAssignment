namespace NewGlobeAssignment.Common.Models.ApiModels.Feature
{
    public class VariationApiModel
    {
        #region Properties

        public string Key { get; set; }

        public string Name { get; set; }

        public List<TargetApiModel> Targets { get; set; }

        public bool Value { get; set; }

        #endregion
    }
}