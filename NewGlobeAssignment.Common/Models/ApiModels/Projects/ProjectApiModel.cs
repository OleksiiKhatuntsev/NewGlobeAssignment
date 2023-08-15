namespace NewGlobeAssignment.Common.Models.ApiModels.Projects
{
    public class ProjectApiModel
    {
        #region Properties

        public string Name { get; set; }

        public string Description { get; set; }

        public string Key { get; set; }

        public DateTime ChangeAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ChangedBy { get; set; }

        public string CreatedBy { get; set; }

        #endregion
    }
}