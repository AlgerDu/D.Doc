using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Core
{

    public interface IProjectVersion
    {
        long Id { get; }

        string Code { get; }

        string Description { get; set; }

        IProject BlongProject { get; }

        IProjectVersion BaseVersion { get; }

        bool IsStable { get; }

        IResult UpdatePattern(string path, DocTreeNode node);

        IResult<DocTreeNode> GetPattern(string path);

        IResult UpdateDocTree(string path, DocTreeNode node);
    }
}
