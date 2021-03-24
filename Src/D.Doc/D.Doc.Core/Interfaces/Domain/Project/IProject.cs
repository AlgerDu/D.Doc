using D.Infrastructures.Domain;
using D.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Core
{
    /// <summary>
    /// 项目（聚合根）
    /// </summary>
    public interface IProject : IAggregateRoot<long>
    {
        string Name { get; set; }

        string Description { get; set; }

        IProjectVersion CurrentVersion { get; }

        IEnumerable<IProjectVersion> Versions { get; }
    }
}
