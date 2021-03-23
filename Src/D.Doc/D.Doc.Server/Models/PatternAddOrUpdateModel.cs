using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D.Doc.Server.Models
{
    public class PatternAddOrUpdateModel
    {
        public string Path { get; set; }

        //public string Data { get; set; }

        public DocModel Data { get; set; }
    }
}
