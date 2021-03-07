using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.PO
{
    /// <summary>
    /// 文档树
    /// </summary>
    public class DocTree : LongEntity
    {
        /// <summary>
        /// 父节点 Id
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// 和父节点的关系
        /// </summary>
        public string Releation { get; set; }

        /// <summary>
        /// 文档的 BID
        /// </summary>
        public long DocBid { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTimeOffset EndTime { get; set; }
    }
}
