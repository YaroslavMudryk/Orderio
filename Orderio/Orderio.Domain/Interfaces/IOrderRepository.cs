using Orderio.Domain.Models;
using Orderio.Shared;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Orderio.Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<PagedList<Order>> GetPagedOrdersAsync(Expression<Func<Order, bool>> expression, int page = 1, int countPerPage = 20);
    }
}
