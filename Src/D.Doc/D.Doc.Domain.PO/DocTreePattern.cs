using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.PO
{
    /// <summary>
    /// 文档树模板
    /// </summary>
    public class DocTreePattern : LongEntity
    {
        /// <summary>
        /// code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 文档树根节点
        /// </summary>
        public long DocTreeRootId { get; set; }
    }
}
