using Emes.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Emes.Core.Data
{
    public class RepositoryWithTypedId<TEntity, TEntityId> : IRepositoryWithTypedId<TEntity, TEntityId> where TEntity : class, IEntityWithTypedId<TEntityId>
    {
        protected readonly DbContext _context;

        protected DbSet<TEntity> _entities;

        public RepositoryWithTypedId(EmesDbContext context)
        {
            _context = context;
        }

        #region Utilities

        /// <summary>
        /// 实体的回滚和返回全错误消息
        /// </summary>
        /// <param name="exception">异常</param>
        /// <returns>错误信息</returns>
        protected string GetFullErrorTextAndRollbackEntityChanges(DbUpdateException exception)
        {
            //回滚实体变化
            if (_context is DbContext dbContext)
            {
                var entries = dbContext.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified).ToList();

                entries.ForEach(entry =>
                {
                    try
                    {
                        entry.State = EntityState.Unchanged;
                    }
                    catch (InvalidOperationException)
                    {
                    }
                });
            }

            _context.SaveChanges();
            return exception.ToString();
        }

        #endregion

        #region Methods


        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 通过id获取entity
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        public virtual async Task<TEntity> GetById(TEntityId id, CancellationToken cancellationToken = default)
        {
            return await Entities.FindAsync(id, cancellationToken);
        }

        /// <summary>
        /// (单个)插入 entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual async Task<TEntity> Add(TEntity entity, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            try
            {
                if (typeof(IEntity).IsAssignableFrom(typeof(TEntity)))
                {
                    var tempEntity = (IEntity)entity;
                    var user = WorkContext.GetCurrentUser();
                    if (tempEntity.OrgId <= 0)
                    {
                        tempEntity.OrgId = user.OrgId;
                    }
                    tempEntity.Version++;
                    tempEntity.CreatedOn = DateTimeOffset.UtcNow;
                    tempEntity.UpdatedOn = DateTimeOffset.UtcNow;
                    tempEntity.CreatedById = user.Id;
                    tempEntity.UpdatedById = user.Id;
                }

                var savedEntity = Entities.Add(entity).Entity;
                if (autoSave)
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
                return savedEntity;
            }
            catch (DbUpdateException exception)
            {
                //确保将详细的错误文本保存在日志中
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }

        /// <summary>
        /// (多个)插入 entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task AddRange(IEnumerable<TEntity> entities, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));
            try
            {

                if (typeof(IEntity).IsAssignableFrom(typeof(TEntity)))
                {
                    var user = WorkContext.GetCurrentUser();
                    foreach (var entity in entities)
                    {
                        var tempEntity = (IEntity)entity;

                        if (tempEntity.OrgId <= 0)
                        {
                            tempEntity.OrgId = user.OrgId;
                        }
                        tempEntity.Version++;
                        tempEntity.CreatedOn = DateTimeOffset.UtcNow;
                        tempEntity.UpdatedOn = DateTimeOffset.UtcNow;
                        tempEntity.CreatedById = user.Id;
                        tempEntity.UpdatedById = user.Id;
                    }
                }
                Entities.AddRange(entities);
                if (autoSave)
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
            }
            catch (DbUpdateException exception)
            {
                //确保将详细的错误文本保存在日志中
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }

        /// <summary>
        /// (单个)更新 entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual async Task<TEntity> Update(TEntity entity, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            try
            {
                if (typeof(IEntity).IsAssignableFrom(typeof(TEntity)))
                {
                    var user = WorkContext.GetCurrentUser();
                    var tempEntity = (IEntity)entity;
                    tempEntity.Version++;
                    tempEntity.UpdatedOn = DateTimeOffset.UtcNow;
                    tempEntity.UpdatedById = user.Id;
                }
                var updatedEntity = Entities.Update(entity).Entity;
                if (autoSave)
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
                return updatedEntity;
            }
            catch (DbUpdateException exception)
            {
                //确保将详细的错误文本保存在日志中
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }

        /// <summary>
        /// (多个)更新 entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task UpdateRange(IEnumerable<TEntity> entities, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                foreach (var entity in entities)
                {
                    var user = WorkContext.GetCurrentUser();
                    if (typeof(IEntity).IsAssignableFrom(typeof(TEntity)))
                    {
                        var tempEntity = (IEntity)entity;
                        tempEntity.Version++;
                        tempEntity.UpdatedOn = DateTimeOffset.UtcNow;
                        tempEntity.UpdatedById = user.Id;
                    }
                }

                Entities.UpdateRange(entities);
                if (autoSave)
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
            }
            catch (DbUpdateException exception)
            {
                //确保将详细的错误文本保存在日志中
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }


        /// <summary>
        /// (单个)删除 entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual async Task Remove(TEntity entity, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            try
            {
                Entities.Remove(entity);
                if (autoSave)
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
            }
            catch (DbUpdateException exception)
            {
                //确保将详细的错误文本保存在日志中
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }

        /// <summary>
        /// (多个)删除 entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task RemoveRange(IEnumerable<TEntity> entities, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            try
            {
                Entities.RemoveRange(entities);
                if (autoSave)
                {
                    await _context.SaveChangesAsync(cancellationToken);
                }
            }
            catch (DbUpdateException exception)
            {
                //确保将详细的错误文本保存在日志中
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }





        #endregion

        #region Properties

        /// <summary>
        /// 获取数据表
        /// </summary>
        public virtual IQueryable<TEntity> Query
        {
            get
            {
                //if (typeof(IEntity).IsAssignableFrom(typeof(TEntity)))
                //    if (Entities.Count() > 1)
                //{
                //    var user = EngineContext.Current.Resolve<IWorkContext>().GetCurrentUser().Result;
                //    if (user.OrgId > 0)
                //    {
                //        return Entities.Where(x => x.OrgId == user.OrgId);
                //    }
                //}

                return Entities;
            }
        }

        /// <summary>
        /// 获得一个“no tracking(没有跟踪)”的表（EF特性），只有当仅为只读操作加载记录（s）时才使用它。
        /// </summary>
        public virtual IQueryable<TEntity> QueryNoTracking
        {
            get
            {
                //if (Entities.Count() > 1)
                //{
                //    var user = EngineContext.Current.Resolve<IWorkContext>().GetCurrentUser().Result;
                //    if (user.OrgId > 0)
                //    {
                //        return Entities.Where(x => x.OrgId == user.OrgId);
                //    }
                //}

                return Entities.AsNoTracking();
            }
        }

        /// <summary>
        /// 得到一个实体集
        /// </summary>
        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity>();
                return _entities;
            }
        }
        #endregion

    }
}
