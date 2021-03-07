﻿using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.PO
{
    /// <summary>
    /// 项目版本
    /// </summary>
    public class Version : LongEntity
    {
        /// <summary>
        /// 版本名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 所属项目
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// 基于哪个版本做的升级
        /// </summary>
        public long BaseVersionId { get; set; }

        /// <summary>
        /// 版本的文档树模板
        /// </summary>
        public long PatternId { get; set; }

        /// <summary>
        /// 文档树根节点 ID
        /// </summary>
        public long DocTreeRootId { get; set; }

        /// <summary>
        /// 是否文档版
        /// </summary>
        public bool IsStable { get; set; }

        /// <summary>
        /// 版本是否已经删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
