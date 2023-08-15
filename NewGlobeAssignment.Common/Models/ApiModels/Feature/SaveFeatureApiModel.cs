namespace NewGlobeAssignment.Common.Models.ApiModels.Feature
{
    public class SaveFeatureApiModel<T>
    {
        public bool Active { get; set; }

        public string ChangedBy { get; set; }

        public string Description { get; set; }

        public T DefaultValue { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public List<VariationApiModel> Variations { get; set; }
    }
}
