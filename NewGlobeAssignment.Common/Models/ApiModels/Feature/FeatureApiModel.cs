namespace NewGlobeAssignment.Common.Models.ApiModels.Feature
{
    public class FeatureApiModel<T>
    {

        public bool Active { get; set; }

        public DateTime ChangedAt { get; set; }

        public string ChangedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public T DefaultValue { get; set; }

        public string Description { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public List<VariationApiModel> Variations { get; set; }

    }
}
