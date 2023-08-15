namespace NewGlobeAssignment.Common.Models.UiModels
{
    public class FeaturesPageModel<T>
    {
        public string FeatureName { get; set; }

        public bool Active { get; set; }

        public string Type { get; set; }

        public T DefaultValue { get; set; }
    }
}
