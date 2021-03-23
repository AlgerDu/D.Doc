using D.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProject
    {
        long Id { get; }

        string Name { get; set; }

        string Description { get; set; }

        IProjectVersion CurrentVersion { get; }

        IEnumerable<IProjectVersion> Versions { get; }
    }
}
