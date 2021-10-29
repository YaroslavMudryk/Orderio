using Orderio.Domain.Models;
using Orderio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Orderio.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseModel
    {
        #region Writable
        Task<TEntity> CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> CreateAsync(IEnumerable<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entities);
        Task<TEntity> RemoveAsync(TEntity entity);
        Task<IEnumerable<TEntity>> RemoveAsync(IEnumerable<TEntity> entities);
        #endregion

        #region Readable
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<PagedList<TEntity>> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate, int page = 1, int countPerPage = 20);
        #endregion
    }
}
