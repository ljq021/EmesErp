using Emes.Core.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Surging.Core.CPlatform.Ioc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Emes.Core.Data
{
    public interface IRepositoryWithTypedId<TEntity, TEntityId> : ITransientDependency where TEntity : IEntityWithTypedId<TEntityId>, IAggregateRoot
    {
        #region Methods

        /// <summary>
        /// 通过id获取entity
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        Task<TEntity> GetById(TEntityId id, CancellationToken cancellationToken = default);

        /// <summary>
        /// (单个)插入 entity
        /// </summary>
        /// <param name="entity">Entity</param>
        Task<TEntity> Add(TEntity entity, bool autoSave = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// (多个)插入 entities
        /// </summary>
        /// <param name="entities">Entities</param>
        Task AddRange(IEnumerable<TEntity> entities, bool autoSave = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// (单个)更新 entity
        /// </summary>
        /// <param name="entity">Entity</param>
        Task<TEntity> Update(TEntity entity, bool autoSave = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// (多个)更新 entities
        /// </summary>
        /// <param name="entities">Entities</param>
        Task UpdateRange(IEnumerable<TEntity> entities, bool autoSave = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// (单个)删除 entity
        /// </summary>
        /// <param name="entity">Entity</param>
        Task Remove(TEntity entity, bool autoSave = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// (多个)删除 entities
        /// </summary>
        /// <param name="entities">Entities</param>
        Task RemoveRange(IEnumerable<TEntity> entities, bool autoSave = true, CancellationToken cancellationToken = default);


        IDbContextTransaction BeginTransaction();

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        #endregion

        #region Properties

        /// <summary>
        /// 获取数据表
        /// </summary>
        IQueryable<TEntity> Query { get; }

        /// <summary>
        /// 获得一个“no tracking(没有跟踪)”的表（EF特性），只有当仅为只读操作加载记录（s）时才使用它。
        /// </summary>
        IQueryable<TEntity> QueryNoTracking { get; }

        #endregion
    }
}
