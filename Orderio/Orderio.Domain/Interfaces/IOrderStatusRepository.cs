using Orderio.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orderio.Domain.Interfaces
{
    public interface IOrderStatusRepository : IRepository<OrderStatus>
    {
        Task<List<OrderStatus>> GetAllOrderStatusesAsync(long orderId);
    }
}
