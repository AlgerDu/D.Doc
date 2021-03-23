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
        long ID { get; }

        string Name { get; set; }

        string Description { get; set; }

        IProjectVersion CurrentVersion { get; }
    }

    public interface IProjectVersion
    {

    }
}
