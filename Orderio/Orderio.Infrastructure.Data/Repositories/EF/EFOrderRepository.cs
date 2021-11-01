using Microsoft.EntityFrameworkCore;
using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;
using Orderio.Shared;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFOrderRepository : EFRepository<Order>, IOrderRepository
    {
        public EFOrderRepository(OrderioContext db) : base(db)
        {
            
        }

        public async Task<PagedList<Order>> GetPagedOrdersAsync(Expression<Func<Order, bool>> predicate, int page = 1, int countPerPage = 20)
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
            var orders = await _db.Orders
                .AsNoTracking()
                .Where(predicate)
                .Skip(page).Take(page)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            return new PagedList<Order>(orders, totalCount, page, countPerPage);
        }
    }
}
