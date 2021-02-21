using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace D.Infrastructures.Domain
{
    /// <summary>
    /// 仓储，只做标识用
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        int SaveChange();
    }

    /// <summary>
    /// 仓储
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public interface IRepository<TEntity, TPrimaryKey> : IRepository
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null);

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(TEntity entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Delete(TPrimaryKey key);

        /// <summary>
        /// 更行
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TEntity entity);

        /// <summary>
        /// 通过主键获取
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TEntity GetByKey(TPrimaryKey key);
    }
}
