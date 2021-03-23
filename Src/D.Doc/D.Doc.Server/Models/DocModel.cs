using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace D.Doc.Server.Models
{
    public class DocModel
    {
        public string Code { get; set; }

        public string Type { get; set; }

        public JsonDocument Data { get; set; }

        public Dictionary<string, DocModel> Properties { get; set; }

        public Dictionary<string, DocModel> Children { get; set; }
    }
}
