using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D.Doc.Server.Models
{
    public class AddProjectModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public AddProjectInitVersionModel InitVersion { get; set; }
    }

    public class AddProjectInitVersionModel
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
