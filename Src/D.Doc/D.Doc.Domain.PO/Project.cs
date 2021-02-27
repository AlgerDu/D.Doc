using D.Infrastructures.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.PO
{
    /// <summary>
    /// 项目；管理的最小单位
    /// </summary>
    public class Project : LongEntity
    {
        /// <summary>
        /// 主键 ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// （外键）项目当前版本记录的主键 ID
        /// </summary>
        public long CurrVersionID { get; set; }

        /// <summary>
        /// 项目是否已经被删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
