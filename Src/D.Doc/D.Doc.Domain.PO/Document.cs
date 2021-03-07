using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.PO
{
    /// <summary>
    /// 文档
    /// </summary>
    public class Document : LongEntity
    {
        /// <summary>
        /// 业务 ID
        /// </summary>
        public long Bid { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 元数据
        /// </summary>
        public long MetadataTreeId { get; set; }
    }
}
