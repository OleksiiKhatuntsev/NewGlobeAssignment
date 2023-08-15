using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGlobeAssignment.Common.Models.ApiModels.Projects
{
    public class SaveProjectApiModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Key { get; set; }

        public string ChangedBy { get; set; }
    }
}
