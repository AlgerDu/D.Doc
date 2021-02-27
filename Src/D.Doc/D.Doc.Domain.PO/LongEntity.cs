using D.Infrastructures.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.PO
{
    /// <summary>
    /// 使用 long 最为主键的 entity
    /// </summary>
    public abstract class LongEntity : IEntity<long>
    {
        ///<inheritdoc/>
        public long PK { get; set; }

        ///<inheritdoc/>
        public bool IsTransient()
        {
            return default(long) == PK;
        }
    }
}
