using System;
using System.Collections.Generic;
using System.Text;

namespace D.Infrastructures.Domain
{
    /// <summary>
    /// 工作单元
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// 开启事务
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// 提交并且结束事务
        /// </summary>
        /// <returns></returns>
        bool Commit();

        /// <summary>
        /// 回滚
        /// </summary>
        void Rollback();
    }
}
