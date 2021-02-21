using System;
using System.Collections.Generic;
using System.Text;

namespace D.Infrastructures.Domain
{
    /// <summary>
    /// 聚合跟（只做标识使用）
    /// </summary>
    public interface IAggregateRoot : IEntity
    {
    }

    /// <summary>
    /// 聚合跟
    /// </summary>
    /// <typeparam name="TPrimaryKey">主键类型</typeparam>
    public interface IAggregateRoot<TPrimaryKey> : IEntity<TPrimaryKey>
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {
    }
}
