using System;
using System.Collections.Generic;
using System.Text;

namespace D.Infrastructures.Domain
{
    /// <summary>
    /// 领域模型 Entity，此接口只是用来某些情况下做标识使用
    /// </summary>
    public interface IEntity
    {

    }

    /// <summary>
    /// 领域模型 Entity，必须有唯一标识
    /// </summary>
    /// <typeparam name="TPrimaryKey">当使用多主键的时候，这里的模型可以是自身</typeparam>
    public interface IEntity<TPrimaryKey> : IEntity
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        TPrimaryKey PK { get; set; }

        /// <summary>
        /// 是否瞬时对象（未持久化的对象）
        /// </summary>
        /// <returns>PK == default(PK)</returns>
        bool IsTransient();
    }
}
