using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace D.Doc.Core
{
    public class DocTreeNode
    {
        public string Code { get; set; }

        public string Type { get; set; }

        public JsonDocument Data { get; set; }

        public Dictionary<string, DocTreeNode> Properties { get; set; }

        public Dictionary<string, DocTreeNode> Children { get; set; }

    }
}
