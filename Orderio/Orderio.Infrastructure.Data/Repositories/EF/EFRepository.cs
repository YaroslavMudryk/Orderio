using Microsoft.EntityFrameworkCore;
using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;
using Orderio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        public SaveChangesResult Result { get; set; }
        protected OrderioContext _db;
        protected DbSet<TEntity> _dbSet;
        public EFRepository(OrderioContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
            Result = new SaveChangesResult();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _db.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<IEnumerable<TEntity>> CreateAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                await _dbSet.AddRangeAsync(entities);
                await _db.SaveChangesAsync();
                return entities;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                return await _dbSet.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _dbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<PagedList<TEntity>> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate, int page = 1, int countPerPage = 20)
        {
            try
            {
                var totalCount = await CountAsync(predicate);
                int skip = 0;
                if (totalCount < countPerPage)
                {
                    countPerPage = totalCount;
                    skip = 0;
                }
                else
                    skip = page > 1 ? (page - 1) * countPerPage : 0;
                var res = await _dbSet.AsNoTracking().Where(predicate).Skip(skip).Take(countPerPage).ToListAsync();
                return new PagedList<TEntity>(res, totalCount, page, countPerPage);
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
                await _db.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<IEnumerable<TEntity>> RemoveAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                _dbSet.RemoveRange(entities);
                await _db.SaveChangesAsync();
                return entities;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _db.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                _dbSet.UpdateRange(entities);
                await _db.SaveChangesAsync();
                return entities;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return null;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            try
            {
                if (predicate is null)
                    return await _dbSet.CountAsync();
                return await _dbSet.CountAsync(predicate);
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return -1;
        }

        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return (await _dbSet.AsNoTracking().Where(predicate).ToListAsync()).Count > 0;
            }
            catch (Exception ex)
            {
                Result.AddException(ex);
            }
            return default;
        }
    }
}
