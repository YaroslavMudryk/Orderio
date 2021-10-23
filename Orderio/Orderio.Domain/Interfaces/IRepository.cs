using Orderio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        Task<List<TEntity>> GetListAsync(Predicate<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(Predicate<Func<TEntity, bool>> predicate);
        Task<PagedList<TEntity>> GetPagedListAsync(Predicate<Func<TEntity, bool>> predicate, int page = 1);
        #endregion
    }
}
